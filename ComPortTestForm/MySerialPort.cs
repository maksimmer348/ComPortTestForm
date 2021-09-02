using System;
using System.Text;
using GodSharp.SerialPort;
using GodSharp.SerialPort.Enums;

namespace ComPortTestForm
{
    public class MySerialPort
    {
        private readonly int Number;
        private readonly int BaudRate;
        private readonly int Parity;
        private GodSerialPort Serial;

        public Action<string> DataReceived;
        public Func<string, string> CommandReceived;
        public event Action<Exception> ReceiveErrorMessage; //вывод исключений

        public bool flag;

        public MySerialPort(int number, int baudRate, int parity)
        {
            Number = number;
            BaudRate = baudRate;
            Parity = parity;

        }

        public void Open()
        {
            if (Serial == null || !Serial.IsOpen)
            {
                Serial = new GodSerialPort($"COM{Number}", BaudRate, Parity);
                Serial.DataFormat = SerialPortDataFormat.Char;
                Serial.Open();
            }
        }
        public void Write(string message)
        {
            const string END_OF_LINE = "\r\n";

            var dataBytes = Encoding.UTF8.GetBytes(message + END_OF_LINE);
            Serial.Write(dataBytes);
            //Serial.WriteAsciiString(message + END_OF_LINE);

        }

        public string Read()
        {
            return Serial.ReadString();

            //var dataBytes = Encoding.UTF8.GetString(Serial.Read());
            //return dataBytes;

        }

        public void Close()
        {
            if (Serial != null && Serial.IsOpen)
            {
                try
                {
                    flag = false;
                    Serial.Close();

                }
                catch (Exception exception)
                {
                    ReceiveErrorMessage?.Invoke(exception);
                    throw;
                }
            }
        }
    }
}