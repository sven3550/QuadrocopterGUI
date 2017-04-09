using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using Drone_Control;

namespace Quadrocopter.User_ctrls
{
    public partial class ctrlMotor : UserControl
    {
        private SerialPort serialPort;
        private int motNr;
        private bool motor_on;
        private int temp_power;

        public ctrlMotor()
        {
            InitializeComponent();
            serialPort = new SerialPort();
        }

        public void initMotor(SerialPort _serialPort, int _motNr)
        {
            serialPort = _serialPort;
            motNr = _motNr;
            this.Name = "Motor " + _motNr;
            this.lblName.Text = this.Name;
            this.txbxDutyCycle.Text = "20";
        }

        public void updateSpeed(int _speed)
        {
            if (_speed >= 0)
            {
                // motor ON
                if (_speed > 0)
                {
                    motor_on = true;
                    setMotOn();
                }
                else
                {
                    motor_on = false;
                    setMotOff();
                }
                // progress bar
                if (this.prbrDutyCycle.InvokeRequired)
                {
                    this.prbrDutyCycle.BeginInvoke((MethodInvoker)delegate () { UI.SetProgressNoAnimation(prbrDutyCycle, _speed); });
                }
                else
                {
                    UI.SetProgressNoAnimation(prbrDutyCycle, _speed);
                }
                // lable
                if (this.lblDutyCycle.InvokeRequired)
                {
                    this.lblDutyCycle.BeginInvoke((MethodInvoker)delegate () { lblDutyCycle.Text = ("Duty Cycle: " + _speed); });
                }
                else
                {
                    lblDutyCycle.Text = ("Duty Cycle: " + _speed); ;
                }
            }
            else
            {
                //Console.WriteLine("trying to update motor speed with invalid vlaue");
            }
        }

        private void txbxDutyCycle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                temp_power = int.Parse(txbxDutyCycle.Text);
                if (serialPort.IsOpen)
                {
                    if (temp_power < 100 && temp_power >= 10)
                    {
                        serialPort.Write("m" + motNr + "0" + txbxDutyCycle.Text + "XXXX?");
                        // ToDo: request the actual duty cycle from the uC and write it into the progressBar
                        //prbrDutyCycle.Value = temp_power;
                    }
                    else if (temp_power < 10)
                    {
                        serialPort.Write("m" + motNr + "00" + txbxDutyCycle.Text + "XXXX?");
                        // ToDo: request the actual duty cycle from the uC and write it into the progressBar
                        //prbrDutyCycle.Value = temp_power;
                    }
                    else if (temp_power == 100)
                    {
                        serialPort.Write("m" + motNr + "100" + "XXXX?");
                        // ToDo: request the actual duty cycle from the uC and write it into the progressBar
                        //prbrDutyCycle.Value = temp_power;
                    }
                    else
                    {
                        Console.WriteLine("invalid input");
                    }
                    
                }
            }
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            txbxDutyCycle_KeyPress(null, new KeyPressEventArgs((char)Keys.Enter));
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            serialPort.Write("m" + motNr + "000" + "XXXX?");
            //prbrDutyCycle.Value = 0;
        }

        private void setMotOn()
        {
            // checked
            if (this.ckbxMotOn.InvokeRequired)
            {
                this.ckbxMotOn.BeginInvoke((MethodInvoker)delegate () { ckbxMotOn.Checked = true; });
            }
            else
            {
                ckbxMotOn.Checked = true;
            }
            // back color
            if (this.ckbxMotOn.InvokeRequired)
            {
                this.ckbxMotOn.BeginInvoke((MethodInvoker)delegate () { ckbxMotOn.BackColor = Color.Green; });
            }
            else
            {
                ckbxMotOn.BackColor = Color.Green;
            }
        }

        private void setMotOff()
        {
            // checked
            if (this.ckbxMotOn.InvokeRequired)
            {
                this.ckbxMotOn.BeginInvoke((MethodInvoker)delegate () { ckbxMotOn.Checked = false; });
            }
            else
            {
                ckbxMotOn.Checked = false;
            }
            // back color
            if (this.ckbxMotOn.InvokeRequired)
            {
                this.ckbxMotOn.BeginInvoke((MethodInvoker)delegate () { ckbxMotOn.BackColor = Color.Red; });
            }
            else
            {
                ckbxMotOn.BackColor = Color.Red;
            }
        }
    }
}
