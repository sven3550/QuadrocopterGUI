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
    public partial class UARTLink : UserControl
    {
        private DateTime timeLastPing = new DateTime();
        private int missedPacketCount;
        private int syncLostCount;

        public UARTLink()
        {
            InitializeComponent();
        }

        private void tmrLastPing_Tick(object sender, EventArgs e)
        {
            lblLastPing.Text = "Last Ping: " + timeLastPing;
            lblMissedPackets.Text = "Missed packets: " + missedPacketCount;
            lblSyncLost.Text = "Sync lost: " + syncLostCount;
        }

        public void startUpdate()
        {
            tmrLastPing.Start();
        }

        public void stopUpdate()
        {
            tmrLastPing.Stop();
        }

        public void setTimeLastPing(DateTime _time)
        {
            timeLastPing = _time;
        }

        public void setMissedPackets(int _packetCount)
        {
            missedPacketCount = _packetCount;
        }

        public void setSyncLost(int _lostCount)
        {
            syncLostCount = _lostCount;
        }
    }
}
