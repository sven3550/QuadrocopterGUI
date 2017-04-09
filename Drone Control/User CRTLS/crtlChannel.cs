using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drone_Control.User_CRTLS
{
    public partial class crtlChannel : UserControl
    {
        private bool Vlaue_known;
        private ushort CHValue;
        private int chNr;
        private ushort last_CHValue;

        public crtlChannel()
        {
            InitializeComponent();
        }

        public void initChannel(int _chNr)
        {
            chNr = _chNr;
            this.Name = "Channel " + _chNr;
            this.lblName.Text = this.Name;
        }

        public void setChannelValue(ushort _chValue)
        {
            // thread safe call
            // lable value
            if (this.lblCHValue.InvokeRequired)
            {
                this.lblCHValue.BeginInvoke((MethodInvoker)delegate () { this.lblCHValue.Text = "Channel Value: " + _chValue.ToString("D4"); ; });
            }
            else
            {
                this.lblCHValue.Text = "Channel Value: " + _chValue.ToString("D4"); ;
            }

            // progressbar
            if (this.prbrCHValue.InvokeRequired)
            {
                this.prbrCHValue.BeginInvoke((MethodInvoker)delegate () { UI.SetProgressNoAnimation(this.prbrCHValue, _chValue); });
            }
            else
            {
                UI.SetProgressNoAnimation(this.prbrCHValue, _chValue); ;
            }
        }

        public void setChannelVlaueKnown(bool _valueKnown)
        {
            if (!_valueKnown)
            {
                this.lblCHValue.Text = "Channel Value: XXXX";
                last_CHValue = CHValue;
            }
            else
            {
                this.lblCHValue.Text = "Channel Value: " + last_CHValue.ToString("D4");
                this.prbrCHValue.Value = last_CHValue;
            }
        }
    }
}
