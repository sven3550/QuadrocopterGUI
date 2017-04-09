namespace Quadrocopter.User_ctrls
{
    partial class ctrlMotor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.btnOff = new System.Windows.Forms.Button();
            this.btnOn = new System.Windows.Forms.Button();
            this.prbrDutyCycle = new System.Windows.Forms.ProgressBar();
            this.lblDutyCycle = new System.Windows.Forms.Label();
            this.txbxDutyCycle = new System.Windows.Forms.TextBox();
            this.lblPowerUnit = new System.Windows.Forms.Label();
            this.ckbxMotOn = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(10, 6);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Motor X";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(64, 88);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(45, 23);
            this.btnOff.TabIndex = 1;
            this.btnOff.Text = "Off";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // btnOn
            // 
            this.btnOn.Location = new System.Drawing.Point(13, 88);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(45, 23);
            this.btnOn.TabIndex = 2;
            this.btnOn.Text = "On";
            this.btnOn.UseVisualStyleBackColor = true;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // prbrDutyCycle
            // 
            this.prbrDutyCycle.Location = new System.Drawing.Point(13, 59);
            this.prbrDutyCycle.MarqueeAnimationSpeed = 50;
            this.prbrDutyCycle.Name = "prbrDutyCycle";
            this.prbrDutyCycle.Size = new System.Drawing.Size(200, 23);
            this.prbrDutyCycle.Step = 1;
            this.prbrDutyCycle.TabIndex = 3;
            // 
            // lblDutyCycle
            // 
            this.lblDutyCycle.AutoSize = true;
            this.lblDutyCycle.Location = new System.Drawing.Point(10, 44);
            this.lblDutyCycle.Name = "lblDutyCycle";
            this.lblDutyCycle.Size = new System.Drawing.Size(85, 13);
            this.lblDutyCycle.TabIndex = 4;
            this.lblDutyCycle.Text = "Duty Cycle: XXX";
            // 
            // txbxDutyCycle
            // 
            this.txbxDutyCycle.Location = new System.Drawing.Point(122, 90);
            this.txbxDutyCycle.Name = "txbxDutyCycle";
            this.txbxDutyCycle.Size = new System.Drawing.Size(46, 20);
            this.txbxDutyCycle.TabIndex = 5;
            this.txbxDutyCycle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbxDutyCycle_KeyPress);
            // 
            // lblPowerUnit
            // 
            this.lblPowerUnit.AutoSize = true;
            this.lblPowerUnit.Location = new System.Drawing.Point(169, 93);
            this.lblPowerUnit.Name = "lblPowerUnit";
            this.lblPowerUnit.Size = new System.Drawing.Size(48, 13);
            this.lblPowerUnit.TabIndex = 6;
            this.lblPowerUnit.Text = "% Power";
            // 
            // ckbxMotOn
            // 
            this.ckbxMotOn.AutoSize = true;
            this.ckbxMotOn.BackColor = System.Drawing.Color.Red;
            this.ckbxMotOn.Enabled = false;
            this.ckbxMotOn.Location = new System.Drawing.Point(113, 6);
            this.ckbxMotOn.Name = "ckbxMotOn";
            this.ckbxMotOn.Size = new System.Drawing.Size(40, 17);
            this.ckbxMotOn.TabIndex = 7;
            this.ckbxMotOn.Text = "On";
            this.ckbxMotOn.UseVisualStyleBackColor = false;
            // 
            // ctrlMotor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ckbxMotOn);
            this.Controls.Add(this.lblPowerUnit);
            this.Controls.Add(this.txbxDutyCycle);
            this.Controls.Add(this.lblDutyCycle);
            this.Controls.Add(this.prbrDutyCycle);
            this.Controls.Add(this.btnOn);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.lblName);
            this.Name = "ctrlMotor";
            this.Size = new System.Drawing.Size(220, 116);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.ProgressBar prbrDutyCycle;
        private System.Windows.Forms.Label lblDutyCycle;
        private System.Windows.Forms.TextBox txbxDutyCycle;
        private System.Windows.Forms.Label lblPowerUnit;
        private System.Windows.Forms.CheckBox ckbxMotOn;
    }
}
