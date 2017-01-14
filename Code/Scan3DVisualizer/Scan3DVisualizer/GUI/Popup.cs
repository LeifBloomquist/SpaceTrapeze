using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
//using Sanford.Multimedia;
//using Sanford.Multimedia.Midi;
using System.IO.Ports;

namespace SkyboxVisualizer
{
    public partial class Popup : Form
    {
//        private InputDevice inDevice = null;
        private SynchronizationContext context;

        OgreForm MainForm = null;

        public Popup(OgreForm Main)
        {
            this.MainForm = Main;
            InitializeComponent();
//            InitializeMIDI();
            InitializeCOMports();
        }

/*
        private void InitializeMIDI()
        {
            int devices = InputDevice.DeviceCount;

 	        if (devices == 0)
            {
                MessageBox.Show("No MIDI input devices available.", "Warning!",  MessageBoxButtons.OK, MessageBoxIcon.Warning);                
            }
            else
            {
                try
                {
                    context = SynchronizationContext.Current;                    
                   
                    for (int i=0; i< devices; i++)
                    {
                        MidiInCaps caps = InputDevice.GetDeviceCapabilities(i);                        
                        MidiDeviceComboBox.Items.Add(caps.name);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Close();
                }
            }
        }
*/
        private void InitializeCOMports()
        {
            string[] ports = SerialPort.GetPortNames();
            ComPortComboBox.Items.Clear();
            ComPortComboBox.Items.AddRange(ports);
        }

        private void SetSkyBox(int skybox)
        {
            if (MainForm != null)
            {
                MainForm.SetSkybox(skybox);
            }
        }

        private void Skybox1_Click(object sender, EventArgs e)
        {
            SetSkyBox(0);
        }

        private void Skybox2_Click(object sender, EventArgs e)
        {
            SetSkyBox(1);
        }

        private void Skybox3_Click(object sender, EventArgs e)
        {
            SetSkyBox(2);
        }

        private void Skybox4_Click(object sender, EventArgs e)
        {
            SetSkyBox(3);
        }

        private void MidiDeviceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = MidiDeviceComboBox.SelectedIndex;
            ConnectMIDI(selected);
        }

        private void ConnectMIDI(int selected)
        {
/*            if (inDevice != null)
            {
                inDevice.Close();
            }

            inDevice = new InputDevice(selected);
            inDevice.ChannelMessageReceived += HandleChannelMessageReceived;     
            inDevice.Error += inDevice_Error;
            inDevice.StartRecording();

 */
        }
         
        protected override void OnClosed(EventArgs e)
        {
//            if(inDevice != null)
//            {
//                inDevice.Close();
//            }

            base.OnClosed(e);
        }
        /*
                private void inDevice_Error(object sender, ErrorEventArgs e)
                {
                    MessageBox.Show(e.Error.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
         * 
                private void HandleChannelMessageReceived(object sender, ChannelMessageEventArgs e)
                {
                    context.Post(delegate(object dummy)
                    {
                        String s = 
                            e.Message.Command.ToString() + ": " +
                            e.Message.MidiChannel.ToString() + '-' +
                            e.Message.Data1.ToString() + '-' +
                            e.Message.Data2.ToString();

                        MIDIDebugLabel.Text = s;

                    }, null);

                    MainForm.SetSkybox(e.Message.Data1);
                }
         * */

        private void ComPortComboBox_Click(object sender, EventArgs e)
        {
            InitializeCOMports();
        }

        Boolean maximized = false;

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            if (MainForm != null)
            {
                if (!maximized)
                {
                    MainForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    MainForm.WindowState = FormWindowState.Maximized;
                    MaximizeButton.Text = "Restore";
                    maximized = true;
                }
                else
                {
                    MainForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                    MainForm.WindowState = FormWindowState.Normal;
                    MaximizeButton.Text = "Maximize";
                    maximized = false;
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "Are you sure?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK) 
            {
                MainForm.Close();
                Application.Exit();
                System.Environment.Exit(0);
            }
        }
    }
}

