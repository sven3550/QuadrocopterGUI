using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Quadrocopter
{
    public partial class MainFrame : Form
    {
        bool MainFormClosing;
        bool init_done;

        // UART RX stuff
        string RXData;
        int SQ_packets_missed;
        int SQ_sync_lost;

        // drone-connetion vars
        bool droneConnected;
        bool uartSynced = true;
        Random rand = new Random(); // random number generator using the system clock
        char[] x1_bytes = new char[3];

        // Drone poll stuf
        Thread tPollDrone;      // periodically requests data from the drone to update the Live-view 
        Thread tPingDrone;      // periodically pings the drone to see if it is still there
        int pingTimeout_ms = 3000;
        int pollTimeout_ms = 400;
        bool halt_poll = true;
        bool halt_ping = true;
        bool ping_active;

        public MainFrame()
        {
            InitializeComponent();
            tPollDrone = new Thread(pollDrone);
            tPingDrone = new Thread(pingDrone);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                serialPort.Open();
            }
            while (!serialPort.IsOpen) ;
            Console.WriteLine("Serial-port open");

            if (!init_done)
            {
                // init UART link details
                uartLink1.startUpdate();
                // init motor panels
                ctrlMotorPanel1.initMotor(serialPort, 1);
                ctrlMotorPanel2.initMotor(serialPort, 2);
                ctrlMotorPanel3.initMotor(serialPort, 3);
                ctrlMotorPanel4.initMotor(serialPort, 4);
                // init channel panels
                crtlChannel1.initChannel(1);
                crtlChannel2.initChannel(2);
                crtlChannel3.initChannel(3);
                crtlChannel4.initChannel(4);
                crtlChannel5.initChannel(5);
                crtlChannel6.initChannel(6);
                // init done
                init_done = true;
            }
            // connect to drone
            RequestConnectionCheck();
            // start thread for polling drone-data
            if (!tPollDrone.IsAlive)
            {
                tPollDrone.Start();
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                halt_poll = true;
                serialPort.Dispose();
                serialPort.Close();
                // update UI
                crtlChannel1.setChannelVlaueKnown(false);
                crtlChannel2.setChannelVlaueKnown(false);
                crtlChannel3.setChannelVlaueKnown(false);
                crtlChannel4.setChannelVlaueKnown(false);
            }
            if (!serialPort.IsOpen)
            {
                ckbxConnected.Checked = false;
                ckbxConnected.BackColor = Color.Red;
            }
        }

        // UART RX interrupt. only fires if at least 4 bytes are in the buffer
        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            //// Syncronization check ///////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            if (!uartSynced)
            {
                RXData = serialPort.ReadExisting();
            }

            // check if SQ_uart is syncronized. If not, wait for '!' and restart uart operation
            if (!uartSynced && RXData.Contains("!"))
            {
                serialPort.DiscardInBuffer();
                serialPort.ReceivedBytesThreshold = 9;
                uartSynced = true;
                return;
            }
            else if (!uartSynced)
            {
                // SQ_uart is not syncronized and didnt recieve the sync char '!' yet
                serialPort.DiscardInBuffer();
                return;
            }

            //RXData = serialPort.ReadTo("?");
            RXData = serialPort.ReadExisting();

            // check if transmission is sync'd
            if (uartSynced && !RXData.Contains("!"))
            {
                // SQ-transmission is not syncronized
                uartSynced = false;
                serialPort.ReceivedBytesThreshold = 1; // set this to 1 to check every incomming byte untli resynced
                // update uart info
                SQ_sync_lost++;
                SQ_packets_missed++;
                //Console.WriteLine("RX data skiped: " + SQ_packets_missed);
                uartLink1.setMissedPackets(SQ_packets_missed);
                uartLink1.setSyncLost(SQ_sync_lost);
                serialPort.DiscardInBuffer();
                return;
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////


            //Console.WriteLine("RX: " + RXData);
            if (uartSynced && RXData.ElementAt(8) == 0x21) // 0x21 = '!'
            {
                // update last-ping
                uartLink1.setTimeLastPing(DateTime.Now);

                // check what kind of data was transmitted
                
                // data = channel value
                if ((RXData.ElementAt(0) == 'c') && (RXData.ElementAt(1) == 'h'))
                {
                    //Console.WriteLine(" Channel: " + RXData.ElementAt(2) + " Value: " + RXData.Substring(3));
                    this.updataChannel((int)Char.GetNumericValue(RXData.ElementAt(2)), (ushort)Convert.ToInt16(RXData.Substring(3,4)));
                }
                // data = warning
                else if ((RXData.ElementAt(0) == 'w'))
                {
                    Console.WriteLine("Warning from drone. Warning_code: " + RXData.ElementAt(2));
                }
                // data = motor speeds
                else if ((RXData.ElementAt(0) == 'm') && (RXData.ElementAt(1) == 'u'))
                {
                    // motor panel 1
                    if (RXData.ElementAt(2) > 0)
                    {
                        ctrlMotorPanel1.updateSpeed((int)RXData.ElementAt(2));
                    }
                    else
                    {
                        ctrlMotorPanel1.updateSpeed(0);
                    }
                    // motor panel 2
                    if (RXData.ElementAt(3) > 0)
                    {
                        ctrlMotorPanel2.updateSpeed((int)RXData.ElementAt(3));
                    }
                    else
                    {
                        ctrlMotorPanel2.updateSpeed(0);
                    }
                    // motor panel 3
                    if (RXData.ElementAt(4) > 0)
                    {
                        ctrlMotorPanel3.updateSpeed((int)RXData.ElementAt(4));
                    }
                    else
                    {
                        ctrlMotorPanel3.updateSpeed(0);
                    }
                    // motor panel 4
                    if (RXData.ElementAt(5) > 0)
                    {
                        ctrlMotorPanel4.updateSpeed((int)RXData.ElementAt(5));
                    }
                    else
                    {
                        ctrlMotorPanel4.updateSpeed(0);
                    }
                }
                // data = connection test
                else if ((RXData.ElementAt(0) == 'x'))
                {
                    Console.WriteLine("Connection check answer: " + RXData);
                    // check if the 3 next bytes match the x1_bytes
                    if (RXData[2] == x1_bytes[0] && RXData[3] == x1_bytes[1] && RXData[4] == x1_bytes[2])
                    {
                        // x1_bytes match. connetion is good
                        setConnected(true);
                        droneConnected = true;
                        uartLink1.setTimeLastPing(DateTime.Now);
                        // enable the tab control
                        if (this.tabControl1.InvokeRequired)
                        {
                            this.tabControl1.BeginInvoke((MethodInvoker)delegate () { tabControl1.Enabled = true; });
                        }
                        else
                        {
                            tabControl1.Enabled = true; ;
                        }
                        
                    }
                    else
                    {
                        // x1_bytes dont match. connetion is bad
                        setConnected(false);
                        droneConnected = false;
                        // disabel the tab control
                        if (this.tabControl1.InvokeRequired)
                        {
                            this.tabControl1.BeginInvoke((MethodInvoker)delegate () { tabControl1.Enabled = false; });
                        }
                        else
                        {
                            tabControl1.Enabled = false; ;
                        }
                    }
                }
                serialPort.DiscardInBuffer();
            }
            else
            {
                if ((uartSynced) && RXData != "")
                {
                    Console.WriteLine("RX error: no ! found. Data: " + RXData);
                }
                else if (uartSynced && RXData == "")
                {
                    Console.WriteLine("RX error: empty buffer");
                }
            }
        }

        // THREAD-FUNCTION: polls data from the drone for the Live-view
        private void pollDrone()
        {
            while (!MainFormClosing)
            {
                while (halt_poll)
                {
                    if (MainFormClosing) { break; }
                }; // wait until poll is requested again

                // channel values
                for (int i = 1; i <= 6; i++)
                {
                    if (halt_poll || MainFormClosing)
                    {
                        break;
                    }
                    // request channel value
                    serialPort.Write("chget" + i + "XXX?");
                    // delay next poll
                    Thread.Sleep(pollTimeout_ms / 16);
                }
                // motor values
                // delay next poll
                Thread.Sleep(pollTimeout_ms);
                // request motor speeds
                serialPort.Write("mu" + "XXXXXXX?"); // request all 4 motor speeds
            }
        }

        // THREAD-FUNCTION: pings the drone to check the connection
        private void pingDrone()
        {
            while (!MainFormClosing)
            {
                while (halt_ping)
                {
                    if (MainFormClosing) { break; }
                }; // wait until ping is requested again

                // ping drone
                RequestConnectionCheck();
                // delay next ping
                Thread.Sleep(pingTimeout_ms);
                if (halt_ping || MainFormClosing)
                {
                    break;
                }
            }

        }

        // updates the UI elements of a specific channel
        private void updataChannel(int _chNr, ushort _value)
        {
            switch (_chNr)
            {
                case 1:
                    crtlChannel1.setChannelValue(_value);
                    break;
                case 2:
                    crtlChannel2.setChannelValue(_value);
                    break;
                case 3:
                    crtlChannel3.setChannelValue(_value);
                    break;
                case 4:
                    crtlChannel4.setChannelValue(_value);
                    break;
                case 5:
                    crtlChannel5.setChannelValue(_value);
                    break;
                case 6:
                    crtlChannel6.setChannelValue(_value);
                    break;
                default:
                    break;
            }
        }

        // pings the drone to check the connection
        private void RequestConnectionCheck()
        {
            // fills x1_bytes with 3 random bytes of int(0..255)
            //x1_bytes[0] = Convert.ToChar(rand.Next(9));
            //x1_bytes[1] = Convert.ToChar(rand.Next(9));
            //x1_bytes[2] = Convert.ToChar(rand.Next(9));
            x1_bytes[0] = Convert.ToChar(35);       // some chars seem to crash the UART transmission
            x1_bytes[1] = Convert.ToChar(35);
            x1_bytes[2] = Convert.ToChar(35);
            serialPort.Write("x1" + x1_bytes[0] + x1_bytes[1] + x1_bytes[2] + "XXXX?");
        }

        // Polling On/Off
        private void rdbtnPollOn_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnPollOn.Checked)
            {
                rdbtnPollOff.Checked = false;
                halt_poll = false;
            }
        }

        private void rdbtnPollOff_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnPollOff.Checked)
            {
                rdbtnPollOn.Checked = false;
                halt_poll = true;
            }
        }

        private void setConnected(bool _connected)
        {
            if (_connected)
            {
                // back color
                if (this.ckbxConnected.InvokeRequired)
                {
                    this.ckbxConnected.BeginInvoke((MethodInvoker)delegate () { ckbxConnected.BackColor = Color.Green; });
                }
                else
                {
                    ckbxConnected.BackColor = Color.Green; ;
                }
                // checkbox checked
                if (this.ckbxConnected.InvokeRequired)
                {
                    this.ckbxConnected.BeginInvoke((MethodInvoker)delegate () { ckbxConnected.Checked = true; });
                }
                else
                {
                    ckbxConnected.Checked = true; ;
                }
            }
            else
            {
                // back color
                if (this.ckbxConnected.InvokeRequired)
                {
                    this.ckbxConnected.BeginInvoke((MethodInvoker)delegate () { ckbxConnected.BackColor = Color.Red; });
                }
                else
                {
                    ckbxConnected.BackColor = Color.Red; ;
                }
                // checkbox checked
                if (this.ckbxConnected.InvokeRequired)
                {
                    this.ckbxConnected.BeginInvoke((MethodInvoker)delegate () { ckbxConnected.Checked = false; });
                }
                else
                {
                    ckbxConnected.Checked = false; ;
                }
            }
        }

        private void MainFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainFormClosing = true;
            serialPort.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RequestConnectionCheck();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort.Write("mu" + "XXXXXXX?"); // request all 4 motor speeds
        }
    }
}
