using Mogre;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace SkyboxVisualizer
{
    public partial class OgreForm : Form
    {
        // Flag to use when exiting
        private bool running = true;

        // Useful Constants
        public static string TITLE = "Space Trapeze 0.1";
        private const float PI = (float)System.Math.PI;

        // Ogre stuff
        Root mRoot;
        RenderWindow mWindow;
        SceneManager mgr = null;
        ManualObject manual = null;
        Camera cam = null;
        CameraMan manager = null;

        SceneNode sno = null;

        // Network stuff
        Network.NetworkListener listener = null;
        private double rxpulse = 0;

        // Animation Timer
        private System.Timers.Timer myTimer = new System.Timers.Timer();

        // Destination Quaternion for SLERP
        Quaternion q_dest = new Quaternion();

        public OgreForm()
        {
            if (Thread.CurrentThread.Name == null)
                Thread.CurrentThread.Name = "GUI Thread";

            InitializeComponent();

            Disposed += new EventHandler(OgreForm_Disposed);
            Resize += new EventHandler(OgreForm_Resize);

            Init3DMouse();

            this.MouseWheel += new MouseEventHandler(OgreForm_MouseWheel);

            Popup pop = new Popup(this);
            pop.Show();

            OpenSerialPort();
        }

        public void Init()
        {
            // Create root object
            mRoot = new Root();

            // Define Resources
            ConfigFile cf = new ConfigFile();
            cf.Load("resources.cfg", "\t:=", true);
            ConfigFile.SectionIterator seci = cf.GetSectionIterator();
            String secName, typeName, archName;

            while (seci.MoveNext())
            {
                secName = seci.CurrentKey;
                ConfigFile.SettingsMultiMap settings = seci.Current;
                foreach (KeyValuePair<string, string> pair in settings)
                {
                    typeName = pair.Key;
                    archName = pair.Value;
                    ResourceGroupManager.Singleton.AddResourceLocation(archName, typeName, secName);
                }
            }

            // Setup RenderSystem
            RenderSystem rs = mRoot.GetRenderSystemByName("Direct3D9 Rendering Subsystem");
            //RenderSystem rs = mRoot.GetRenderSystemByName("OpenGL Rendering Subsystem");

            mRoot.RenderSystem = rs;
            rs.SetConfigOption("Full Screen", "No");
            rs.SetConfigOption("Video Mode", "800 x 600 @ 32-bit colour");

            // Create Render Window  (inside PictureBox)
            mRoot.Initialise(false, "Main Ogre Window");
            NameValuePairList misc = new NameValuePairList();
            misc["externalWindowHandle"] = OgreBox.Handle.ToString();   //  Handle.ToString();
            misc["FSAA"] = "2";        // anti aliasing factor (0, 2, 4 ...)
            misc["vsync"] = "true";    // by Ogre default: false

            mWindow = mRoot.CreateRenderWindow("Main RenderWindow", 800, 600, false, misc);

            // Init resources
            TextureManager.Singleton.DefaultNumMipmaps = 5;
            ResourceGroupManager.Singleton.InitialiseAllResourceGroups();

            // Create a Simple Scene            
            mgr = mRoot.CreateSceneManager(SceneType.ST_GENERIC);
            cam = mgr.CreateCamera("Camera");
            cam.AutoAspectRatio = true;
            cam.NearClipDistance = 0.01f;
            cam.FarClipDistance = float.MaxValue;

            mWindow.AddViewport(cam);
            CreateScene();

            try
            {
                // Start the Camera Manager
                manager = new CameraMan(cam);

                // Start the network
                listener = new Network.NetworkListener(this);
            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Exception:\n\n" + e.Message + "\n\n" + e.GetBaseException().ToString());
            }
        }

        public void Go()
        {
            Show();

            // Sets the timer interval to 50 milliseconds.
            myTimer.Elapsed += TimerEventProcessor;
            myTimer.Interval = 50;
            myTimer.Start();

            while (running)
            {
                Quaternion q_current = cam.Orientation;
                Quaternion q_slerp = Quaternion.Slerp(0.9f, q_dest, q_current, true);

                if (cam != null)
                {
                    cam.Orientation = q_slerp;
                }

                // Original code continues

                if (mRoot != null)
                {
                    mRoot.RenderOneFrame();
                }

                manager.Process();

                try
                {
                    RenderTarget.FrameStats stats = mWindow.GetStatistics();
                    FPSLabel.Text = "FPS: " + stats.LastFPS.ToString("0.00");
                    String pos = " X:" + cam.Position.x.ToString("0.00") +
                                 " Y:" + cam.Position.y.ToString("0.00") +
                                 " Z:" + cam.Position.z.ToString("0.00");
                    CamLabel.Text = "Camera:" + pos;
                }
                catch (Exception e)
                {
                    StatusLabel.Text = "Exception: " + e.Message;
                }

                Application.DoEvents();
            }
        }

        void OgreForm_Disposed(object sender, EventArgs e)
        {
            mRoot.Dispose();
            mRoot = null;
        }

        void OgreForm_Resize(object sender, EventArgs e)
        {
            mWindow.WindowMovedOrResized();
        }

        private void OgreForm_MouseWheel(object sender, MouseEventArgs e)
        {
            int delta = e.Delta;

            /*
            var move = Vector3.ZERO;            
            move += cam.Direction * delta;

            if (manager.FastMove)
            {
                move *= 10;  // Super fast
            }     

            if (move != Vector3.ZERO)
            {
                cam.Move(move);
            }
    */
        }

        private void CreateScene()
        {
            if (mgr == null) return;
            mgr.ClearScene();

            mgr.AmbientLight = new ColourValue(1, 1, 1);

            manual = mgr.CreateManualObject("PointCloud");
            mgr.RootSceneNode.CreateChildSceneNode("PointCloudNode").AttachObject(manual);
            mgr.DisplaySceneNodes = false;

            manual.Dynamic = true;

            // Initial SkyBox
            SetSkybox(0);

            HomePosition();
        }

        // This is the method to run when the timer is raised.
        // Animates the background of the RX LEDs.
        private void TimerEventProcessor(Object myObject, ElapsedEventArgs myEventArgs)
        {
            if (Thread.CurrentThread.Name == null)
                Thread.CurrentThread.Name = "Timer Thread?";

            int red = (int)(rxpulse * 255);
            rxpulse *= 0.4;

            try
            {
                this.Invoke(new Action(() =>
                {
                    RXLabel.BackColor = Color.FromArgb(red, 0, 0);
                }));
            }
            catch (Exception)
            {
                ;
            }
        }


        private void LoadScanButton_Click(object sender, EventArgs e)
        {
            // Deleted

            // 3. Reset view to home position
            HomePosition();
        }

        // Called from Network thread
        public void PlotIncomingData(byte[] ScanData)
        {
            this.Invoke(new Action(() =>
            {
                rxpulse = 1.0;
                // Deleted

                // UpdateIntensityMinMax?  In Future perhaps

                //PlotScanDataThread(ScanPoints);
            }));
        }

        private void UpdateStatus(string message)
        {
            SafeUpdateStatus(message, false);
        }

        public void SafeUpdateStatus(String message, bool refresh)
        {
            if (this.IsDisposed)
            {
                return;
            }

            try
            {
                this.Invoke(new Action(() =>
                {
                    StatusLabel.Text = message;
                    if (refresh) Refresh();
                }));
            }
            catch (Exception)  //  Despite the above check, this still occasionally happens on shutdown.  Weird!
            {
                ;   // Ignore silently.
            }
        }

        int skybox = 0;

        public void SetSkybox(int skybox)
        {
            switch (skybox)
            {
                case 0:
                    mgr.SetSkyBox(true, "BlueStarsSkyBox");
                    break;

                case 1:
                    mgr.SetSkyBox(true, "NebulaSkyBox");                   
                    break;

                case 2:
                    mgr.SetSkyBox(true, "RedNebulaSkyBox");
                    break;

                 case 3:
                    mgr.SetSkyBox(true, "GalaxySkyBox");
                    break;

                default:
                    skybox = 0;
                    break;
            }
        }

        private bool dragging = false;
        private Point previousLocation;

        private void OgreBox_MouseDown(object sender, MouseEventArgs e)
        {
            OgreBox.Cursor = Cursors.SizeAll;
            dragging = true;
        }

        private void OgreBox_MouseUp(object sender, MouseEventArgs e)
        {
            OgreBox.Cursor = Cursors.Hand;
            dragging = false;
        }

        private void OgreBox_MouseMove(object sender, MouseEventArgs e)
        {
            Point difference = e.Location - (Size)previousLocation;

            if (dragging)
            {
                manager.MouseMovement(-(float)difference.X, -(float)difference.Y);
            }

            previousLocation = e.Location;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys key)
        {
            manager.ProcessKeyDown(key);
            return base.ProcessCmdKey(ref msg, key);
        }

        private void OgreForm_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = (Keys)e.KeyCode;
            manager.ProcessKeyDown(key);
        }

        private void OgreForm_KeyUp(object sender, KeyEventArgs e)
        {
            Keys key = (Keys)e.KeyCode;
            manager.ProcessKeyUp(key);
        }

        private void ViewAllButton_Click(object sender, EventArgs e)
        {
            if (cam == null) return;

            try
            {
                cam.LookAt(manual.BoundingBox.Center);
            }
            catch (Exception)
            {
                ;   // Masks the error when scene is empty, no bounding box
            }
        }

        private void HomePosition()
        {
            cam.Position = new Vector3(0, 0, 0);
            cam.LookAt(new Vector3(0, 0, -10000f));
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            HomePosition();
        }

        private void ClearScanButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Clear Scan", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }

            manual.DetachFromParent();
            manual.Dispose();
            CreateScene();

            this.Text = OgreForm.TITLE;

            TotalPointsReceived = 0;
            ValidReturn = 0;
            ValidReturnOverFlow = 0;
            NoReturn = 0;
            MissingSample = 0;
            BeyondThreshold = 0;

            MaxIntensity = 0;
            MinIntensity = 0;
        }

        private void NetworkListenButton_Click(object sender, EventArgs e)
        {
            listener.StartListening();
            NetworkListenButton.Visible = false;
            NetworkDisconnectButton.Visible = true;
            LoadScanButton.Enabled = false;
        }

        public void Disconnect()
        {
            listener.StopListening();
            NetworkListenButton.Visible = true;
            NetworkDisconnectButton.Visible = false;
            LoadScanButton.Enabled = true;
        }

        private void NetworkDisconnectButton_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void OgreForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            myTimer.Stop();
            running = false;
            Application.Exit();
        }

        private void ShowStatsButton_Click(object sender, EventArgs e)
        {
            String message = "Total Scan Data Points: " + TotalPointsReceived + "\n\n" +
                             "Valid Return: " + ValidReturn + "\n" +
                             "Valid Return Overflow: " + ValidReturnOverFlow + "\n" +
                             "No Return: " + NoReturn + "\n" +
                             "Missing Sample: " + MissingSample + "\n\n" +
                             "Beyond Range Threshold: " + BeyondThreshold + "\n\n" +
                             "Maximum Intensity: " + MaxIntensity + "\n" +
                             "Minimum Intensity: " + MinIntensity;

            MessageBox.Show(message, "Scan Data Statistics", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BackgroundButton_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = true;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = false;
            // Sets the initial color select to the current text color.
            MyDialog.Color = Color.Black;

            // Update the text box color if the user clicks OK  
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                mWindow.GetViewport(0).BackgroundColour = new ColourValue(MyDialog.Color.R / 255f,
                                                                          MyDialog.Color.G / 255f,
                                                                          MyDialog.Color.B / 255f,
                                                                          MyDialog.Color.A / 255f);

            }
        }

        private void LoadMeshButton_Click(object sender, EventArgs ea)
        {
            // Create an entity from the mesh:
            Entity orion = mgr.CreateEntity("Orion", "orion.mesh");

            // Attach the entity to a SceneNode:
            sno = mgr.RootSceneNode.CreateChildSceneNode("OrionNode");
            sno.AttachObject(orion);
            sno.Position = new Vector3(0, 0, -50);
        }

        // Serial Port Stuff ---------------------------------------------------------------------------------------
        private SerialPort radio_serialport = null;
        private SerialPort midi_serialport = null;

        private void OpenSerialButton_Click(object sender, EventArgs e)
        {
            OpenSerialPort();
        }


        private void OpenSerialPort()
        {
            radio_serialport = new SerialPort("COM44", 38400, Parity.None, 8, StopBits.One);  // Start Bits=1 by default                            
           // midi_serialport = new SerialPort("COM11", 38400, Parity.None, 8, StopBits.One);  // Start Bits=1 by default                            

            try
            {
                radio_serialport.Open();
          //      midi_serialport.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.ToString() + "\nStack Trace:" + ex.StackTrace,
                                "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            radio_serialport.ReceivedBytesThreshold = 1;
            radio_serialport.DataReceived += DataReceived;
        }

        const int NUM_SAMPLES = 20;

        SimpleMovingAverage qw_ave = new SimpleMovingAverage(NUM_SAMPLES);
        SimpleMovingAverage qx_ave = new SimpleMovingAverage(NUM_SAMPLES);
        SimpleMovingAverage qy_ave = new SimpleMovingAverage(NUM_SAMPLES);
        SimpleMovingAverage qz_ave = new SimpleMovingAverage(NUM_SAMPLES);
        SimpleMovingAverage yaw_ave = new SimpleMovingAverage(NUM_SAMPLES);
        SimpleMovingAverage pitch_ave = new SimpleMovingAverage(NUM_SAMPLES);
        SimpleMovingAverage roll_ave = new SimpleMovingAverage(NUM_SAMPLES);        

        const float D2R = (float)(System.Math.PI / 180.0d);

        /// Callback for received data
        /// From MSDN:
        ///  The DataReceived event is raised on a secondary thread when data is received from the SerialPort object. 
        ///  Because this event is raised on a secondary thread, and not the main thread, attempting to modify some elements 
        ///  in the main thread, such as UI elements, could raise a threading exception. If it is necessary to modify elements 
        ///  in the main Form or Control, post change requests back using Invoke, which will do the work on the proper thread.
        internal void DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (Thread.CurrentThread.Name == null)
                Thread.CurrentThread.Name = "Async Serial Receive Thread";

            try
            {
                // Get the data
                SerialPort sp = (SerialPort)sender;
                string indata = radio_serialport.ReadLine();

                string[] values = indata.Split(',');

                // Parse the values
                long sequence = long.Parse(values[0]);

                float qw =    (float)Double.Parse(values[1]);
                float qx =    (float)Double.Parse(values[2]);
                float qy =    (float)Double.Parse(values[3]);
                float qz =    (float)Double.Parse(values[4]);
                float yaw =   (float)Double.Parse(values[5]);
                float pitch = (float)Double.Parse(values[6]);
                float roll =  (float)Double.Parse(values[7]);

                rxpulse = 1.0;

                this.Invoke((MethodInvoker)delegate
                {
                    DebugInfo.Text =
                        "Seq: " + sequence.ToString() + "\n\n" +
                        "QW: " + qw.ToString() + "\n" +
                        "QX: " + qx.ToString() + "\n" +
                        "QY: " + qy.ToString() + "\n" +
                        "QZ: " + qz.ToString() + "\n\n" +
                        "Yaw: " + yaw.ToString() + "\n" +
                        "Pitch: " + pitch.ToString() + "\n" +
                        "Roll: " + roll.ToString();
                });

              /*
                qw_ave.AddSample(qw);
                qx_ave.AddSample(qx);
                qy_ave.AddSample(qy);
                qz_ave.AddSample(qz);
                yaw_ave.AddSample(yaw);
                pitch_ave.AddSample(pitch);
                roll_ave.AddSample(roll);
              */

                //UpdateCamera(ToRadians(-yaw_ave.Average), ToRadians(pitch_ave.Average),  ToRadians(roll_ave.Average));

                 // q_dest = new Quaternion(qw, qx, qy, qz);
                  q_dest = new Quaternion(qw, qx, -qy, -qz);   // Works according to Chris Langley!!
            }
            catch (Exception)   // Usually parsing errors from incomplete strings
            {
                return;  // Exit silently
            }
        }

        private float ToRadians(float degree)
        {
            return (float)(degree*System.Math.PI / 180f);
        }

        private void UpdateCamera(float yaw, float pitch, float roll)
        {
            // Swap things around
            float yaw1 = pitch;
            float pitch1 = -roll;
            float roll1 = -yaw;

            Quaternion q = CreateFromYawPitchRoll(yaw1, pitch1, roll1);

            if (cam != null)
            {
                //cam.Orientation = q;
                q_dest = q;
            }
        }
       
        // from http://stackoverflow.com/questions/11492299/quaternion-to-euler-angles-algorithm-how-to-convert-to-y-up-and-between-ha
        // with x and w swapped
 
        public static Quaternion CreateFromYawPitchRoll(float yaw, float pitch, float roll)
        {
            float rollOver2 = roll * 0.5f;
            float sinRollOver2 = (float)System.Math.Sin((double)rollOver2);
            float cosRollOver2 = (float)System.Math.Cos((double)rollOver2);
            float pitchOver2 = pitch * 0.5f;
            float sinPitchOver2 = (float)System.Math.Sin((double)pitchOver2);
            float cosPitchOver2 = (float)System.Math.Cos((double)pitchOver2);
            float yawOver2 = yaw * 0.5f;
            float sinYawOver2 = (float)System.Math.Sin((double)yawOver2);
            float cosYawOver2 = (float)System.Math.Cos((double)yawOver2);
 
            Quaternion result;
            result.w = cosYawOver2 * cosPitchOver2 * cosRollOver2 + sinYawOver2 * sinPitchOver2 * sinRollOver2; // x
            result.y = cosYawOver2 * cosPitchOver2 * sinRollOver2 - sinYawOver2 * sinPitchOver2 * cosRollOver2; // y
            result.z = cosYawOver2 * sinPitchOver2 * cosRollOver2 + sinYawOver2 * cosPitchOver2 * sinRollOver2; // z
            result.x = sinYawOver2 * cosPitchOver2 * cosRollOver2 - cosYawOver2 * sinPitchOver2 * sinRollOver2; // w
            return result;
        }







        private Mogre.Radian ConvertToRadians(double angle)
        {
            return (Mogre.Radian)((System.Math.PI / 180) * angle);
        }

        private void ForwardMIDI(
            float ax,
            float ay,
            float az,
            float gx,
            float gy,
            float gz,
            float mx,
            float my,
            float mz)
        {

            // Convert data to MIDI CC's
            byte axcc = AccelToCC(ax);
            byte aycc = AccelToCC(ay);
            byte azcc = AccelToCC(az);
            byte amcc = 0;  // Not used in this app
            byte gxcc = GyroToCC(gx);
            byte gycc = GyroToCC(gy);
            byte gzcc = GyroToCC(gz);
            byte mxcc = MagToCC(mx);
            byte mycc = MagToCC(my);
            byte mzcc = MagToCC(mz);

            sendMIDI(0xB0, 20, axcc);   // X = Channel 1, CC#20
            sendMIDI(0xB0, 21, aycc);   // Y = Channel 1, CC#21
            sendMIDI(0xB0, 22, azcc);   // Z = Channel 1, CC#22
            sendMIDI(0xB0, 23, amcc);   // M = Channel 1, CC#23
            sendMIDI(0xB0, 24, gxcc);   // X = Channel 1, CC#24
            sendMIDI(0xB0, 25, gycc);   // Y = Channel 1, CC#25
            sendMIDI(0xB0, 26, gzcc);   // Z = Channel 1, CC#26
            sendMIDI(0xB0, 27, mxcc);   // X = Channel 1, CC#27
            sendMIDI(0xB0, 28, mycc);   // Y = Channel 1, CC#28
            sendMIDI(0xB0, 29, mzcc);   // Z = Channel 1, CC#29
        }

        private void sendMIDI(byte cmd, byte data1, byte data2)
        {
            byte[] dataArray = new byte[3];
            dataArray[0] = cmd;
            dataArray[1] = data1;
            dataArray[2] = data2;

            try
            {
                midi_serialport.Write("");
                midi_serialport.Write(dataArray, 0, dataArray.Length);
            }
            catch (Exception e)
            {
                MessageBox.Show(this, "MIDI Exception:\n\n" + e.Message + "\n\n" + e.GetBaseException().ToString());
            }
        }

        // Map an input between MIN and MAX to 0 to 127
        private byte AccelToCC(float raw)
        {
            float temp = Scale(raw, -1.0f, 1.0f);   // was 1.0
            return (byte)(temp * 127);
        }

        // Map an input between MIN and MAX to 0 to 127
        private byte GyroToCC(float raw)
        {
            float temp = Scale(raw, -5f, 5f);   // was 10
            return (byte)(temp * 127);
        }

        // Map an input between MIN and MAX to 0 to 127
        private byte MagToCC(float raw)
        {
            float temp = Scale(raw, -70f, 70f);
            return (byte)(temp * 127);
        }


        // Scale one of the inputs to between 0.0 and 1.0
        private float Scale(float raw, float smin, float smax)
        {
            // Bound
            if (raw > smax) raw = smax;
            if (raw < smin) raw = smin;

            // Change zero-offset
            raw = raw - smin;

            // Scale between 0.0 and 1.0    (0.5 would be halfway)
            float temp = (float)raw / ((float)smax - (float)smin);
            return temp;
        }

        private void DebugInfo_Click(object sender, EventArgs e)
        {
            DebugInfo.Visible = false;
        }

        private void OgreBox_MouseClick(object sender, MouseEventArgs e)
        {
          
        }
    }
}
