namespace Quadrocopter
{
    partial class MainFrame
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.btnConnect = new System.Windows.Forms.Button();
            this.ckbxConnected = new System.Windows.Forms.CheckBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.grbxConnection = new System.Windows.Forms.GroupBox();
            this.lblPoll = new System.Windows.Forms.Label();
            this.rdbtnPollOn = new System.Windows.Forms.RadioButton();
            this.rdbtnPollOff = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.uartLink1 = new Drone_Control.User_CRTLS.UARTLink();
            this.ctrlMotorPanel1 = new Quadrocopter.User_ctrls.ctrlMotor();
            this.ctrlMotorPanel2 = new Quadrocopter.User_ctrls.ctrlMotor();
            this.ctrlMotorPanel3 = new Quadrocopter.User_ctrls.ctrlMotor();
            this.crtlChannel6 = new Drone_Control.User_CRTLS.crtlChannel();
            this.ctrlMotorPanel4 = new Quadrocopter.User_ctrls.ctrlMotor();
            this.crtlChannel5 = new Drone_Control.User_CRTLS.crtlChannel();
            this.crtlChannel1 = new Drone_Control.User_CRTLS.crtlChannel();
            this.crtlChannel2 = new Drone_Control.User_CRTLS.crtlChannel();
            this.crtlChannel3 = new Drone_Control.User_CRTLS.crtlChannel();
            this.crtlChannel4 = new Drone_Control.User_CRTLS.crtlChannel();
            this.grbxConnection.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 115200;
            this.serialPort.PortName = "COM3";
            this.serialPort.ReadBufferSize = 10;
            this.serialPort.ReceivedBytesThreshold = 9;
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(5, 42);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(79, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // ckbxConnected
            // 
            this.ckbxConnected.AutoSize = true;
            this.ckbxConnected.BackColor = System.Drawing.Color.Red;
            this.ckbxConnected.Enabled = false;
            this.ckbxConnected.Location = new System.Drawing.Point(6, 19);
            this.ckbxConnected.Name = "ckbxConnected";
            this.ckbxConnected.Size = new System.Drawing.Size(78, 17);
            this.ckbxConnected.TabIndex = 6;
            this.ckbxConnected.Text = "Connected";
            this.ckbxConnected.UseVisualStyleBackColor = false;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(5, 72);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(79, 23);
            this.btnDisconnect.TabIndex = 7;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // grbxConnection
            // 
            this.grbxConnection.Controls.Add(this.ckbxConnected);
            this.grbxConnection.Controls.Add(this.btnDisconnect);
            this.grbxConnection.Controls.Add(this.btnConnect);
            this.grbxConnection.Location = new System.Drawing.Point(12, 12);
            this.grbxConnection.Name = "grbxConnection";
            this.grbxConnection.Size = new System.Drawing.Size(90, 105);
            this.grbxConnection.TabIndex = 8;
            this.grbxConnection.TabStop = false;
            this.grbxConnection.Text = "Connection";
            // 
            // lblPoll
            // 
            this.lblPoll.AutoSize = true;
            this.lblPoll.Location = new System.Drawing.Point(690, 9);
            this.lblPoll.Name = "lblPoll";
            this.lblPoll.Size = new System.Drawing.Size(50, 13);
            this.lblPoll.TabIndex = 17;
            this.lblPoll.Text = "Poll Data";
            // 
            // rdbtnPollOn
            // 
            this.rdbtnPollOn.AutoSize = true;
            this.rdbtnPollOn.Location = new System.Drawing.Point(693, 25);
            this.rdbtnPollOn.Name = "rdbtnPollOn";
            this.rdbtnPollOn.Size = new System.Drawing.Size(39, 17);
            this.rdbtnPollOn.TabIndex = 18;
            this.rdbtnPollOn.Text = "On";
            this.rdbtnPollOn.UseVisualStyleBackColor = true;
            this.rdbtnPollOn.CheckedChanged += new System.EventHandler(this.rdbtnPollOn_CheckedChanged);
            // 
            // rdbtnPollOff
            // 
            this.rdbtnPollOff.AutoSize = true;
            this.rdbtnPollOff.Checked = true;
            this.rdbtnPollOff.Location = new System.Drawing.Point(693, 41);
            this.rdbtnPollOff.Name = "rdbtnPollOff";
            this.rdbtnPollOff.Size = new System.Drawing.Size(39, 17);
            this.rdbtnPollOff.TabIndex = 19;
            this.rdbtnPollOff.TabStop = true;
            this.rdbtnPollOff.Text = "Off";
            this.rdbtnPollOff.UseVisualStyleBackColor = true;
            this.rdbtnPollOff.CheckedChanged += new System.EventHandler(this.rdbtnPollOff_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(763, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "con check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(763, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "speed update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(12, 124);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1001, 653);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ctrlMotorPanel1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.ctrlMotorPanel2);
            this.tabPage1.Controls.Add(this.ctrlMotorPanel3);
            this.tabPage1.Controls.Add(this.rdbtnPollOff);
            this.tabPage1.Controls.Add(this.crtlChannel6);
            this.tabPage1.Controls.Add(this.rdbtnPollOn);
            this.tabPage1.Controls.Add(this.ctrlMotorPanel4);
            this.tabPage1.Controls.Add(this.lblPoll);
            this.tabPage1.Controls.Add(this.crtlChannel5);
            this.tabPage1.Controls.Add(this.crtlChannel1);
            this.tabPage1.Controls.Add(this.crtlChannel2);
            this.tabPage1.Controls.Add(this.crtlChannel3);
            this.tabPage1.Controls.Add(this.crtlChannel4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(993, 627);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Live-view";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(993, 627);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // uartLink1
            // 
            this.uartLink1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uartLink1.Location = new System.Drawing.Point(120, 19);
            this.uartLink1.Name = "uartLink1";
            this.uartLink1.Size = new System.Drawing.Size(204, 96);
            this.uartLink1.TabIndex = 25;
            // 
            // ctrlMotorPanel1
            // 
            this.ctrlMotorPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlMotorPanel1.Location = new System.Drawing.Point(6, 6);
            this.ctrlMotorPanel1.Name = "ctrlMotorPanel1";
            this.ctrlMotorPanel1.Size = new System.Drawing.Size(220, 116);
            this.ctrlMotorPanel1.TabIndex = 2;
            // 
            // ctrlMotorPanel2
            // 
            this.ctrlMotorPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlMotorPanel2.Location = new System.Drawing.Point(232, 6);
            this.ctrlMotorPanel2.Name = "ctrlMotorPanel2";
            this.ctrlMotorPanel2.Size = new System.Drawing.Size(220, 116);
            this.ctrlMotorPanel2.TabIndex = 3;
            // 
            // ctrlMotorPanel3
            // 
            this.ctrlMotorPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlMotorPanel3.Location = new System.Drawing.Point(232, 128);
            this.ctrlMotorPanel3.Name = "ctrlMotorPanel3";
            this.ctrlMotorPanel3.Size = new System.Drawing.Size(220, 116);
            this.ctrlMotorPanel3.TabIndex = 4;
            // 
            // crtlChannel6
            // 
            this.crtlChannel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crtlChannel6.Location = new System.Drawing.Point(458, 487);
            this.crtlChannel6.Name = "crtlChannel6";
            this.crtlChannel6.Size = new System.Drawing.Size(170, 86);
            this.crtlChannel6.TabIndex = 21;
            // 
            // ctrlMotorPanel4
            // 
            this.ctrlMotorPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlMotorPanel4.Location = new System.Drawing.Point(6, 128);
            this.ctrlMotorPanel4.Name = "ctrlMotorPanel4";
            this.ctrlMotorPanel4.Size = new System.Drawing.Size(220, 116);
            this.ctrlMotorPanel4.TabIndex = 5;
            // 
            // crtlChannel5
            // 
            this.crtlChannel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crtlChannel5.Location = new System.Drawing.Point(458, 395);
            this.crtlChannel5.Name = "crtlChannel5";
            this.crtlChannel5.Size = new System.Drawing.Size(170, 86);
            this.crtlChannel5.TabIndex = 20;
            // 
            // crtlChannel1
            // 
            this.crtlChannel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crtlChannel1.Location = new System.Drawing.Point(458, 6);
            this.crtlChannel1.Name = "crtlChannel1";
            this.crtlChannel1.Size = new System.Drawing.Size(170, 86);
            this.crtlChannel1.TabIndex = 13;
            // 
            // crtlChannel2
            // 
            this.crtlChannel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crtlChannel2.Location = new System.Drawing.Point(458, 108);
            this.crtlChannel2.Name = "crtlChannel2";
            this.crtlChannel2.Size = new System.Drawing.Size(170, 86);
            this.crtlChannel2.TabIndex = 14;
            // 
            // crtlChannel3
            // 
            this.crtlChannel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crtlChannel3.Location = new System.Drawing.Point(458, 207);
            this.crtlChannel3.Name = "crtlChannel3";
            this.crtlChannel3.Size = new System.Drawing.Size(170, 86);
            this.crtlChannel3.TabIndex = 15;
            // 
            // crtlChannel4
            // 
            this.crtlChannel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crtlChannel4.Location = new System.Drawing.Point(458, 303);
            this.crtlChannel4.Name = "crtlChannel4";
            this.crtlChannel4.Size = new System.Drawing.Size(170, 86);
            this.crtlChannel4.TabIndex = 16;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 806);
            this.Controls.Add(this.uartLink1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.grbxConnection);
            this.Name = "MainFrame";
            this.Text = "Quadrocopter Interface";
            this.grbxConnection.ResumeLayout(false);
            this.grbxConnection.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button btnConnect;
        private User_ctrls.ctrlMotor ctrlMotorPanel1;
        private User_ctrls.ctrlMotor ctrlMotorPanel2;
        private User_ctrls.ctrlMotor ctrlMotorPanel3;
        private User_ctrls.ctrlMotor ctrlMotorPanel4;
        private System.Windows.Forms.CheckBox ckbxConnected;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.GroupBox grbxConnection;
        private Drone_Control.User_CRTLS.crtlChannel crtlChannel1;
        private Drone_Control.User_CRTLS.crtlChannel crtlChannel2;
        private Drone_Control.User_CRTLS.crtlChannel crtlChannel3;
        private Drone_Control.User_CRTLS.crtlChannel crtlChannel4;
        private System.Windows.Forms.Label lblPoll;
        private System.Windows.Forms.RadioButton rdbtnPollOn;
        private System.Windows.Forms.RadioButton rdbtnPollOff;
        private Drone_Control.User_CRTLS.crtlChannel crtlChannel5;
        private Drone_Control.User_CRTLS.crtlChannel crtlChannel6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Drone_Control.User_CRTLS.UARTLink uartLink1;
    }
}

