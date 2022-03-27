using System;
using System.Diagnostics;
using System.IO.Ports;
using System.Threading;

namespace RobotControl
{
    class SerialInterface
    {
        private const string PortIsClosedExceptionMessage = "The port is closed";
        SerialPort comPort;
        Thread readThread;

        public SerialInterface(string portName, int baudRate)
        {
            comPort = new SerialPort
            {
                PortName = portName,
                BaudRate = baudRate,
                Parity = Parity.None,
                DataBits = 8,
                StopBits = StopBits.One,
                Handshake = Handshake.None
            };

            comPort.Open();

            readThread = new Thread(Read);
            readThread.Start();
        }

        ~SerialInterface()
        {
            CloseConnection();
        }

        public void CloseConnection()
        {
            comPort.Close();
        }

        public static string[] GetPorts()
        {
            return SerialPort.GetPortNames();
        }

        public void SendCommand(byte servo, byte angle)
        {
            if(comPort != null)
            {
                byte[] output = new byte[] { 0xFF, servo, angle, (byte)(servo + angle) };
                comPort.Write(output, 0, 4);
            }
        }

        public void Read()
        {
            var _continue = true;
            while (_continue)
            {
                try
                {
                    string message = comPort.ReadLine();
                    Debug.WriteLine(message);
                }
                catch (TimeoutException) { }
                catch (OperationCanceledException)
                {
                    _continue = false;
                }
                catch (InvalidOperationException e) when (e.Message == PortIsClosedExceptionMessage)
                {
                    _continue = false;
                }
            }
        }
    }
}
