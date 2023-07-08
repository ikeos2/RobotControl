using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.IO.Ports;
using System.Threading;

namespace RobotControl.Serial
{
    public class SerialInterface
    {
        private const string PortIsClosedExceptionMessage = "The port is closed";
        SerialPort comPort;
        Thread readThread, writeThread;
        ConcurrentQueue<Instruction> queue;

        public SerialInterface(string portName, int baudRate)
        {
            queue = new();

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

            writeThread = new Thread(CommandSenderFunction);
            writeThread.Start();
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

        public void SendCommand(Instruction instr)
        {
            queue.Enqueue(instr);
        }

        private void CommandSenderFunction()
        {
            while(true)
            {
                if(queue.TryDequeue(out var instruction))
                {
                    SendCommand(1, instruction.baseServoAngle);
                    SendCommand(2, instruction.joint1Angle);
                    SendCommand(3, instruction.joint2Angle);
                    Thread.Sleep(instruction.delay);
                }
                else
                {
                    Thread.Sleep(1000);
                }
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
