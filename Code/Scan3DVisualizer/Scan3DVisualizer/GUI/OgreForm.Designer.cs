namespace SkyboxVisualizer
{
    partial class OgreForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgreForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.CamLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.FPSLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Spacer = new System.Windows.Forms.ToolStripStatusLabel();
            this.Mouse3DLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.RXLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.OgreBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NetworkListenButton = new System.Windows.Forms.Button();
            this.LoadScanButton = new System.Windows.Forms.Button();
            this.NetworkDisconnectButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ViewAllButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.ClearScanButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IntensityLimitMax = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.IntensityLimitMin = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Threshold = new System.Windows.Forms.NumericUpDown();
            this.InvertEL = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BackgroundButton = new System.Windows.Forms.Button();
            this.ShowStatsButton = new System.Windows.Forms.Button();
            this.ControlsPanel = new System.Windows.Forms.Panel();
            this.OpenSerial_Button = new System.Windows.Forms.Button();
            this.LoadMeshButton = new System.Windows.Forms.Button();
            this.DebugInfo = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OgreBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntensityLimitMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntensityLimitMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Threshold)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.ControlsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.CamLabel,
            this.FPSLabel,
            this.Spacer,
            this.Mouse3DLabel,
            this.toolStripStatusLabel2,
            this.RXLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 844);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1298, 28);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 61;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Visible = false;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = false;
            this.StatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.StatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.StatusLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(400, 23);
            this.StatusLabel.Text = "Status:  Program Running";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CamLabel
            // 
            this.CamLabel.AutoSize = false;
            this.CamLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.CamLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.CamLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CamLabel.Name = "CamLabel";
            this.CamLabel.Size = new System.Drawing.Size(400, 23);
            this.CamLabel.Text = "Camera:  --  --  --";
            this.CamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FPSLabel
            // 
            this.FPSLabel.AutoSize = false;
            this.FPSLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.FPSLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.FPSLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FPSLabel.Name = "FPSLabel";
            this.FPSLabel.Size = new System.Drawing.Size(100, 23);
            this.FPSLabel.Text = "-- FPS";
            this.FPSLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Spacer
            // 
            this.Spacer.AutoSize = false;
            this.Spacer.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spacer.Name = "Spacer";
            this.Spacer.Size = new System.Drawing.Size(291, 23);
            this.Spacer.Spring = true;
            // 
            // Mouse3DLabel
            // 
            this.Mouse3DLabel.AutoSize = false;
            this.Mouse3DLabel.BackColor = System.Drawing.Color.Black;
            this.Mouse3DLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.Mouse3DLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Mouse3DLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mouse3DLabel.ForeColor = System.Drawing.Color.White;
            this.Mouse3DLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Mouse3DLabel.Name = "Mouse3DLabel";
            this.Mouse3DLabel.Size = new System.Drawing.Size(40, 23);
            this.Mouse3DLabel.Text = "3D";
            this.Mouse3DLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 23);
            // 
            // RXLabel
            // 
            this.RXLabel.AutoSize = false;
            this.RXLabel.BackColor = System.Drawing.Color.Red;
            this.RXLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.RXLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RXLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RXLabel.ForeColor = System.Drawing.Color.White;
            this.RXLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RXLabel.Name = "RXLabel";
            this.RXLabel.Size = new System.Drawing.Size(40, 23);
            this.RXLabel.Text = "RX";
            this.RXLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // OgreBox
            // 
            this.OgreBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OgreBox.BackColor = System.Drawing.Color.Black;
            this.OgreBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OgreBox.Location = new System.Drawing.Point(0, 0);
            this.OgreBox.Name = "OgreBox";
            this.OgreBox.Size = new System.Drawing.Size(1298, 890);
            this.OgreBox.TabIndex = 0;
            this.OgreBox.TabStop = false;
            this.OgreBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OgreBox_MouseClick);
            this.OgreBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OgreBox_MouseDown);
            this.OgreBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OgreBox_MouseMove);
            this.OgreBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OgreBox_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.NetworkListenButton);
            this.groupBox1.Controls.Add(this.LoadScanButton);
            this.groupBox1.Controls.Add(this.NetworkDisconnectButton);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 158);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Source";
            // 
            // NetworkListenButton
            // 
            this.NetworkListenButton.BackColor = System.Drawing.Color.Black;
            this.NetworkListenButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetworkListenButton.ForeColor = System.Drawing.Color.White;
            this.NetworkListenButton.Image = ((System.Drawing.Image)(resources.GetObject("NetworkListenButton.Image")));
            this.NetworkListenButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NetworkListenButton.Location = new System.Drawing.Point(9, 86);
            this.NetworkListenButton.Name = "NetworkListenButton";
            this.NetworkListenButton.Size = new System.Drawing.Size(117, 61);
            this.NetworkListenButton.TabIndex = 16;
            this.NetworkListenButton.Text = "Network";
            this.NetworkListenButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NetworkListenButton.UseVisualStyleBackColor = false;
            this.NetworkListenButton.Click += new System.EventHandler(this.NetworkListenButton_Click);
            // 
            // LoadScanButton
            // 
            this.LoadScanButton.BackColor = System.Drawing.Color.Black;
            this.LoadScanButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadScanButton.ForeColor = System.Drawing.Color.White;
            this.LoadScanButton.Image = ((System.Drawing.Image)(resources.GetObject("LoadScanButton.Image")));
            this.LoadScanButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LoadScanButton.Location = new System.Drawing.Point(9, 20);
            this.LoadScanButton.Name = "LoadScanButton";
            this.LoadScanButton.Size = new System.Drawing.Size(117, 61);
            this.LoadScanButton.TabIndex = 5;
            this.LoadScanButton.Text = "Load Scan";
            this.LoadScanButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LoadScanButton.UseVisualStyleBackColor = false;
            this.LoadScanButton.Click += new System.EventHandler(this.LoadScanButton_Click);
            // 
            // NetworkDisconnectButton
            // 
            this.NetworkDisconnectButton.BackColor = System.Drawing.Color.Black;
            this.NetworkDisconnectButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetworkDisconnectButton.ForeColor = System.Drawing.Color.White;
            this.NetworkDisconnectButton.Image = ((System.Drawing.Image)(resources.GetObject("NetworkDisconnectButton.Image")));
            this.NetworkDisconnectButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NetworkDisconnectButton.Location = new System.Drawing.Point(10, 86);
            this.NetworkDisconnectButton.Name = "NetworkDisconnectButton";
            this.NetworkDisconnectButton.Size = new System.Drawing.Size(117, 61);
            this.NetworkDisconnectButton.TabIndex = 61;
            this.NetworkDisconnectButton.Text = "Disconnect";
            this.NetworkDisconnectButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NetworkDisconnectButton.UseVisualStyleBackColor = false;
            this.NetworkDisconnectButton.Visible = false;
            this.NetworkDisconnectButton.Click += new System.EventHandler(this.NetworkDisconnectButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.ViewAllButton);
            this.groupBox2.Controls.Add(this.HomeButton);
            this.groupBox2.Controls.Add(this.ClearScanButton);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(2, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 222);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View";
            // 
            // ViewAllButton
            // 
            this.ViewAllButton.BackColor = System.Drawing.Color.Black;
            this.ViewAllButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAllButton.ForeColor = System.Drawing.Color.White;
            this.ViewAllButton.Image = ((System.Drawing.Image)(resources.GetObject("ViewAllButton.Image")));
            this.ViewAllButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ViewAllButton.Location = new System.Drawing.Point(9, 85);
            this.ViewAllButton.Name = "ViewAllButton";
            this.ViewAllButton.Size = new System.Drawing.Size(117, 61);
            this.ViewAllButton.TabIndex = 16;
            this.ViewAllButton.Text = "Center Scan";
            this.ViewAllButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ViewAllButton.UseVisualStyleBackColor = false;
            this.ViewAllButton.Click += new System.EventHandler(this.ViewAllButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.Black;
            this.HomeButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.HomeButton.Location = new System.Drawing.Point(9, 18);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(117, 61);
            this.HomeButton.TabIndex = 5;
            this.HomeButton.Text = "Home Position";
            this.HomeButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // ClearScanButton
            // 
            this.ClearScanButton.BackColor = System.Drawing.Color.Black;
            this.ClearScanButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearScanButton.ForeColor = System.Drawing.Color.White;
            this.ClearScanButton.Image = ((System.Drawing.Image)(resources.GetObject("ClearScanButton.Image")));
            this.ClearScanButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ClearScanButton.Location = new System.Drawing.Point(10, 150);
            this.ClearScanButton.Name = "ClearScanButton";
            this.ClearScanButton.Size = new System.Drawing.Size(117, 61);
            this.ClearScanButton.TabIndex = 17;
            this.ClearScanButton.Text = "Clear Scan";
            this.ClearScanButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ClearScanButton.UseVisualStyleBackColor = false;
            this.ClearScanButton.Click += new System.EventHandler(this.ClearScanButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.IntensityLimitMax);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.IntensityLimitMin);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.Threshold);
            this.groupBox3.Controls.Add(this.InvertEL);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(3, 395);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(137, 184);
            this.groupBox3.TabIndex = 61;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Load Options";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "max";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "min";
            // 
            // IntensityLimitMax
            // 
            this.IntensityLimitMax.BackColor = System.Drawing.Color.Black;
            this.IntensityLimitMax.ForeColor = System.Drawing.Color.White;
            this.IntensityLimitMax.Location = new System.Drawing.Point(55, 145);
            this.IntensityLimitMax.Maximum = new decimal(new int[] {
            16384,
            0,
            0,
            0});
            this.IntensityLimitMax.Name = "IntensityLimitMax";
            this.IntensityLimitMax.Size = new System.Drawing.Size(73, 23);
            this.IntensityLimitMax.TabIndex = 5;
            this.IntensityLimitMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.IntensityLimitMax.Value = new decimal(new int[] {
            16384,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Intensity Limits";
            // 
            // IntensityLimitMin
            // 
            this.IntensityLimitMin.BackColor = System.Drawing.Color.Black;
            this.IntensityLimitMin.ForeColor = System.Drawing.Color.White;
            this.IntensityLimitMin.Location = new System.Drawing.Point(55, 116);
            this.IntensityLimitMin.Maximum = new decimal(new int[] {
            16384,
            0,
            0,
            0});
            this.IntensityLimitMin.Name = "IntensityLimitMin";
            this.IntensityLimitMin.Size = new System.Drawing.Size(73, 23);
            this.IntensityLimitMin.TabIndex = 3;
            this.IntensityLimitMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Threshold [m]";
            // 
            // Threshold
            // 
            this.Threshold.BackColor = System.Drawing.Color.Black;
            this.Threshold.DecimalPlaces = 3;
            this.Threshold.ForeColor = System.Drawing.Color.White;
            this.Threshold.Location = new System.Drawing.Point(13, 66);
            this.Threshold.Maximum = new decimal(new int[] {
            16777215,
            0,
            0,
            196608});
            this.Threshold.Name = "Threshold";
            this.Threshold.Size = new System.Drawing.Size(113, 23);
            this.Threshold.TabIndex = 1;
            this.Threshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Threshold.Value = new decimal(new int[] {
            16777215,
            0,
            0,
            196608});
            // 
            // InvertEL
            // 
            this.InvertEL.AutoSize = true;
            this.InvertEL.Location = new System.Drawing.Point(13, 22);
            this.InvertEL.Name = "InvertEL";
            this.InvertEL.Size = new System.Drawing.Size(68, 19);
            this.InvertEL.TabIndex = 0;
            this.InvertEL.Text = "Invert";
            this.InvertEL.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BackgroundButton);
            this.groupBox4.Controls.Add(this.ShowStatsButton);
            this.groupBox4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(3, 585);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(137, 107);
            this.groupBox4.TabIndex = 62;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Display";
            // 
            // BackgroundButton
            // 
            this.BackgroundButton.BackColor = System.Drawing.Color.Black;
            this.BackgroundButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackgroundButton.ForeColor = System.Drawing.Color.White;
            this.BackgroundButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BackgroundButton.Location = new System.Drawing.Point(10, 22);
            this.BackgroundButton.Name = "BackgroundButton";
            this.BackgroundButton.Size = new System.Drawing.Size(117, 34);
            this.BackgroundButton.TabIndex = 21;
            this.BackgroundButton.Text = "Background";
            this.BackgroundButton.UseVisualStyleBackColor = false;
            this.BackgroundButton.Click += new System.EventHandler(this.BackgroundButton_Click);
            // 
            // ShowStatsButton
            // 
            this.ShowStatsButton.BackColor = System.Drawing.Color.Black;
            this.ShowStatsButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowStatsButton.ForeColor = System.Drawing.Color.White;
            this.ShowStatsButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ShowStatsButton.Location = new System.Drawing.Point(9, 62);
            this.ShowStatsButton.Name = "ShowStatsButton";
            this.ShowStatsButton.Size = new System.Drawing.Size(117, 34);
            this.ShowStatsButton.TabIndex = 20;
            this.ShowStatsButton.Text = "Statistics";
            this.ShowStatsButton.UseVisualStyleBackColor = false;
            this.ShowStatsButton.Click += new System.EventHandler(this.ShowStatsButton_Click);
            // 
            // ControlsPanel
            // 
            this.ControlsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlsPanel.BackColor = System.Drawing.Color.Black;
            this.ControlsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ControlsPanel.Controls.Add(this.OpenSerial_Button);
            this.ControlsPanel.Controls.Add(this.LoadMeshButton);
            this.ControlsPanel.Controls.Add(this.groupBox4);
            this.ControlsPanel.Controls.Add(this.groupBox3);
            this.ControlsPanel.Controls.Add(this.groupBox2);
            this.ControlsPanel.Controls.Add(this.groupBox1);
            this.ControlsPanel.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlsPanel.ForeColor = System.Drawing.Color.White;
            this.ControlsPanel.Location = new System.Drawing.Point(68, 13);
            this.ControlsPanel.Name = "ControlsPanel";
            this.ControlsPanel.Size = new System.Drawing.Size(152, 882);
            this.ControlsPanel.TabIndex = 60;
            this.ControlsPanel.Visible = false;
            // 
            // OpenSerial_Button
            // 
            this.OpenSerial_Button.BackColor = System.Drawing.Color.Black;
            this.OpenSerial_Button.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenSerial_Button.ForeColor = System.Drawing.Color.White;
            this.OpenSerial_Button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.OpenSerial_Button.Location = new System.Drawing.Point(12, 765);
            this.OpenSerial_Button.Name = "OpenSerial_Button";
            this.OpenSerial_Button.Size = new System.Drawing.Size(117, 34);
            this.OpenSerial_Button.TabIndex = 63;
            this.OpenSerial_Button.Text = "Open Serial";
            this.OpenSerial_Button.UseVisualStyleBackColor = false;
            this.OpenSerial_Button.Click += new System.EventHandler(this.OpenSerialButton_Click);
            // 
            // LoadMeshButton
            // 
            this.LoadMeshButton.BackColor = System.Drawing.Color.Black;
            this.LoadMeshButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadMeshButton.ForeColor = System.Drawing.Color.White;
            this.LoadMeshButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LoadMeshButton.Location = new System.Drawing.Point(13, 720);
            this.LoadMeshButton.Name = "LoadMeshButton";
            this.LoadMeshButton.Size = new System.Drawing.Size(117, 34);
            this.LoadMeshButton.TabIndex = 63;
            this.LoadMeshButton.Text = "Load Mesh";
            this.LoadMeshButton.UseVisualStyleBackColor = false;
            this.LoadMeshButton.Click += new System.EventHandler(this.LoadMeshButton_Click);
            // 
            // DebugInfo
            // 
            this.DebugInfo.BackColor = System.Drawing.Color.Transparent;
            this.DebugInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DebugInfo.ForeColor = System.Drawing.Color.White;
            this.DebugInfo.Location = new System.Drawing.Point(13, 13);
            this.DebugInfo.Name = "DebugInfo";
            this.DebugInfo.Size = new System.Drawing.Size(100, 166);
            this.DebugInfo.TabIndex = 62;
            this.DebugInfo.Text = "--";
            this.DebugInfo.Click += new System.EventHandler(this.DebugInfo_Click);
            // 
            // OgreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1298, 872);
            this.Controls.Add(this.DebugInfo);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ControlsPanel);
            this.Controls.Add(this.OgreBox);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "OgreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Skybox Visualizer 1.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OgreForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OgreForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OgreForm_KeyUp);
            this.Resize += new System.EventHandler(this.OgreForm_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OgreBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntensityLimitMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntensityLimitMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Threshold)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ControlsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel Spacer;
        private System.Windows.Forms.ToolStripStatusLabel RXLabel;
        private System.Windows.Forms.ToolStripStatusLabel CamLabel;
        private System.Windows.Forms.ToolStripStatusLabel FPSLabel;
        private System.Windows.Forms.PictureBox OgreBox;
        private System.Windows.Forms.ToolStripStatusLabel Mouse3DLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button NetworkListenButton;
        private System.Windows.Forms.Button LoadScanButton;
        private System.Windows.Forms.Button NetworkDisconnectButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ViewAllButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button ClearScanButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Threshold;
        private System.Windows.Forms.CheckBox InvertEL;
        private System.Windows.Forms.Panel ControlsPanel;
        private System.Windows.Forms.Button BackgroundButton;
        private System.Windows.Forms.Button ShowStatsButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown IntensityLimitMin;
        private System.Windows.Forms.NumericUpDown IntensityLimitMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button LoadMeshButton;
        private System.Windows.Forms.Button OpenSerial_Button;
        private System.Windows.Forms.Label DebugInfo;
    }
}