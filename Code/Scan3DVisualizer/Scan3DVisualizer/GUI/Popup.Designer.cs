namespace SkyboxVisualizer
{
    partial class Popup
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Skybox4 = new System.Windows.Forms.Button();
            this.Skybox3 = new System.Windows.Forms.Button();
            this.Skybox2 = new System.Windows.Forms.Button();
            this.Skybox1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ComPortComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MidiDeviceComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.MIDIDebugLabel = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.MaximizeButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SOMO Sensor Data";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 143);
            this.label1.TabIndex = 0;
            this.label1.Text = "--";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Skybox4);
            this.groupBox2.Controls.Add(this.Skybox3);
            this.groupBox2.Controls.Add(this.Skybox2);
            this.groupBox2.Controls.Add(this.Skybox1);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 61);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Skybox Selection";
            // 
            // Skybox4
            // 
            this.Skybox4.ForeColor = System.Drawing.Color.Black;
            this.Skybox4.Location = new System.Drawing.Point(252, 19);
            this.Skybox4.Name = "Skybox4";
            this.Skybox4.Size = new System.Drawing.Size(75, 36);
            this.Skybox4.TabIndex = 3;
            this.Skybox4.Text = "Skybox 4";
            this.Skybox4.UseVisualStyleBackColor = true;
            this.Skybox4.Click += new System.EventHandler(this.Skybox4_Click);
            // 
            // Skybox3
            // 
            this.Skybox3.ForeColor = System.Drawing.Color.Black;
            this.Skybox3.Location = new System.Drawing.Point(170, 19);
            this.Skybox3.Name = "Skybox3";
            this.Skybox3.Size = new System.Drawing.Size(75, 36);
            this.Skybox3.TabIndex = 2;
            this.Skybox3.Text = "Skybox 3";
            this.Skybox3.UseVisualStyleBackColor = true;
            this.Skybox3.Click += new System.EventHandler(this.Skybox3_Click);
            // 
            // Skybox2
            // 
            this.Skybox2.ForeColor = System.Drawing.Color.Black;
            this.Skybox2.Location = new System.Drawing.Point(88, 19);
            this.Skybox2.Name = "Skybox2";
            this.Skybox2.Size = new System.Drawing.Size(75, 36);
            this.Skybox2.TabIndex = 1;
            this.Skybox2.Text = "Skybox 2";
            this.Skybox2.UseVisualStyleBackColor = true;
            this.Skybox2.Click += new System.EventHandler(this.Skybox2_Click);
            // 
            // Skybox1
            // 
            this.Skybox1.ForeColor = System.Drawing.Color.Black;
            this.Skybox1.Location = new System.Drawing.Point(6, 19);
            this.Skybox1.Name = "Skybox1";
            this.Skybox1.Size = new System.Drawing.Size(75, 36);
            this.Skybox1.TabIndex = 0;
            this.Skybox1.Text = "Skybox 1";
            this.Skybox1.UseVisualStyleBackColor = true;
            this.Skybox1.Click += new System.EventHandler(this.Skybox1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ComPortComboBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.MidiDeviceComboBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(184, 72);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(163, 108);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Configuration";
            // 
            // ComPortComboBox
            // 
            this.ComPortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComPortComboBox.FormattingEnabled = true;
            this.ComPortComboBox.Location = new System.Drawing.Point(7, 35);
            this.ComPortComboBox.Name = "ComPortComboBox";
            this.ComPortComboBox.Size = new System.Drawing.Size(148, 22);
            this.ComPortComboBox.TabIndex = 2;
            this.ComPortComboBox.Click += new System.EventHandler(this.ComPortComboBox_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "COM Port";
            // 
            // MidiDeviceComboBox
            // 
            this.MidiDeviceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MidiDeviceComboBox.FormattingEnabled = true;
            this.MidiDeviceComboBox.Location = new System.Drawing.Point(7, 79);
            this.MidiDeviceComboBox.Name = "MidiDeviceComboBox";
            this.MidiDeviceComboBox.Size = new System.Drawing.Size(148, 22);
            this.MidiDeviceComboBox.TabIndex = 0;
            this.MidiDeviceComboBox.SelectedIndexChanged += new System.EventHandler(this.MidiDeviceComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "MIDI Device";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.MIDIDebugLabel);
            this.groupBox4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(184, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(163, 56);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "MIDI Data";
            // 
            // MIDIDebugLabel
            // 
            this.MIDIDebugLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MIDIDebugLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MIDIDebugLabel.Location = new System.Drawing.Point(7, 20);
            this.MIDIDebugLabel.Name = "MIDIDebugLabel";
            this.MIDIDebugLabel.Size = new System.Drawing.Size(148, 24);
            this.MIDIDebugLabel.TabIndex = 0;
            this.MIDIDebugLabel.Text = "--";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ExitButton);
            this.groupBox5.Controls.Add(this.MaximizeButton);
            this.groupBox5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(12, 253);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(335, 61);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Window Control";
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.ForeColor = System.Drawing.Color.Black;
            this.MaximizeButton.Location = new System.Drawing.Point(6, 19);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Size = new System.Drawing.Size(75, 36);
            this.MaximizeButton.TabIndex = 0;
            this.MaximizeButton.Text = "Maximize";
            this.MaximizeButton.UseVisualStyleBackColor = true;
            this.MaximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.ForeColor = System.Drawing.Color.Red;
            this.ExitButton.Location = new System.Drawing.Point(252, 19);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 36);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(359, 324);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Popup";
            this.Opacity = 0.8D;
            this.Text = "Skybox Controller";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Skybox1;
        private System.Windows.Forms.Button Skybox4;
        private System.Windows.Forms.Button Skybox3;
        private System.Windows.Forms.Button Skybox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label MIDIDebugLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox MidiDeviceComboBox;
        private System.Windows.Forms.ComboBox ComPortComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button MaximizeButton;
        private System.Windows.Forms.Button ExitButton;
    }
}