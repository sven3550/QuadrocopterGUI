namespace Drone_Control.User_CRTLS
{
    partial class UARTLink
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
            this.components = new System.ComponentModel.Container();
            this.lblName = new System.Windows.Forms.Label();
            this.tmrLastPing = new System.Windows.Forms.Timer(this.components);
            this.lblLastPing = new System.Windows.Forms.Label();
            this.lblMissedPackets = new System.Windows.Forms.Label();
            this.lblSyncLost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(4, 4);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(112, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Connection details";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrLastPing
            // 
            this.tmrLastPing.Tick += new System.EventHandler(this.tmrLastPing_Tick);
            // 
            // lblLastPing
            // 
            this.lblLastPing.AutoSize = true;
            this.lblLastPing.Location = new System.Drawing.Point(7, 33);
            this.lblLastPing.Name = "lblLastPing";
            this.lblLastPing.Size = new System.Drawing.Size(57, 13);
            this.lblLastPing.TabIndex = 2;
            this.lblLastPing.Text = "Last Ping: ";
            // 
            // lblMissedPackets
            // 
            this.lblMissedPackets.AutoSize = true;
            this.lblMissedPackets.Location = new System.Drawing.Point(7, 52);
            this.lblMissedPackets.Name = "lblMissedPackets";
            this.lblMissedPackets.Size = new System.Drawing.Size(87, 13);
            this.lblMissedPackets.TabIndex = 3;
            this.lblMissedPackets.Text = "Missed packets: ";
            // 
            // lblSyncLost
            // 
            this.lblSyncLost.AutoSize = true;
            this.lblSyncLost.Location = new System.Drawing.Point(7, 72);
            this.lblSyncLost.Name = "lblSyncLost";
            this.lblSyncLost.Size = new System.Drawing.Size(56, 13);
            this.lblSyncLost.TabIndex = 4;
            this.lblSyncLost.Text = "Sync lost: ";
            // 
            // UARTLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblSyncLost);
            this.Controls.Add(this.lblMissedPackets);
            this.Controls.Add(this.lblLastPing);
            this.Controls.Add(this.lblName);
            this.Name = "UARTLink";
            this.Size = new System.Drawing.Size(204, 96);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Timer tmrLastPing;
        private System.Windows.Forms.Label lblLastPing;
        private System.Windows.Forms.Label lblMissedPackets;
        private System.Windows.Forms.Label lblSyncLost;
    }
}
