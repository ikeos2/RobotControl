using System;
using System.Threading;
using System.Windows.Forms;

namespace RobotControl
{
    public partial class Form1 : Form
    {
        SerialInterface comPort;
        bool connected;

        public Form1()
        {
            connected = false;

            string[] ports = SerialInterface.GetPorts();

            InitializeComponent();
            baudRateSelector.Value = 38400; //default value

            if(ports.Length > 0)
            {
                portSelector.DataSource = ports;
            } else
            {
                portSelector.Enabled = false;
            }
            
            SetConnectionStatus(false);
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if(connected)
            {
                Disconnect();
                SetConnectionStatus(false);
                return;
            }

            if (string.IsNullOrEmpty(portSelector.Text)  || baudRateSelector.Value == 0)
            {
                return;
            }
            try
            {
                int baudRate = int.Parse(baudRateSelector.Text);
                comPort = new SerialInterface(portSelector.Text, baudRate);
                SetConnectionStatus(true);
            } catch (Exception) { } // eat the excpetion
        }

        private void Disconnect()
        {
            if(comPort != null)
            {
                comPort.CloseConnection();
            }
        }

        private void SetConnectionStatus(bool newConnectionStatus)
        {
            if (newConnectionStatus)
            {
                connected = true;
                connectButton.Text = "Disconnect";
                connectionStatusLabel.Text = "Connected";
                connectionStatusLabel.BackColor = System.Drawing.Color.Green;
                return;
            }
            connected = false;
            connectButton.Text = "Connect";
            connectionStatusLabel.Text = "Disconnected";
            connectionStatusLabel.BackColor = System.Drawing.Color.Red;
        }

        private void SendTest_Click(object sender, EventArgs e)
        {
            if (!connected) return;
            comPort.SendCommand(1, (byte)servo1Control.Value);
            comPort.SendCommand(2, (byte)joint1Control.Value);
            comPort.SendCommand(3, (byte)joint2Control.Value);
        }

        private void Sweep(object sender, EventArgs e)
        {
            if (!connected) return;
            int delay = 15;
            for(byte i = 0; i < 180; i++)
            {
                comPort.SendCommand(1, i);
                comPort.SendCommand(2, i);
                comPort.SendCommand(3, i);
                Thread.Sleep(delay);
            }
            for (byte i = 180; i > 0; i--)
            {
                comPort.SendCommand(1, i);
                comPort.SendCommand(2, i);
                comPort.SendCommand(3, i);
                Thread.Sleep(delay);
            }
        }
    }
}
