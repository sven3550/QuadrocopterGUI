namespace Drone_Control.User_CRTLS
{
    partial class crtlChannel
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
            this.prbrCHValue = new System.Windows.Forms.ProgressBar();
            this.lblCHValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(3, 5);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Channel X";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prbrCHValue
            // 
            this.prbrCHValue.Location = new System.Drawing.Point(9, 54);
            this.prbrCHValue.MarqueeAnimationSpeed = 0;
            this.prbrCHValue.Maximum = 2048;
            this.prbrCHValue.Name = "prbrCHValue";
            this.prbrCHValue.Size = new System.Drawing.Size(153, 23);
            this.prbrCHValue.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbrCHValue.TabIndex = 2;
            // 
            // lblCHValue
            // 
            this.lblCHValue.AutoSize = true;
            this.lblCHValue.Location = new System.Drawing.Point(9, 38);
            this.lblCHValue.Name = "lblCHValue";
            this.lblCHValue.Size = new System.Drawing.Size(110, 13);
            this.lblCHValue.TabIndex = 5;
            this.lblCHValue.Text = "Channel Value: XXXX";
            // 
            // crtlChannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblCHValue);
            this.Controls.Add(this.prbrCHValue);
            this.Controls.Add(this.lblName);
            this.Name = "crtlChannel";
            this.Size = new System.Drawing.Size(170, 86);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ProgressBar prbrCHValue;
        private System.Windows.Forms.Label lblCHValue;
    }
}
