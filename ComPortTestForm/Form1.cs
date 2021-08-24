using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GodSharp.SerialPort;
using static ComPortTestForm.CommandsSupplyPSH;

namespace ComPortTestForm
{
    public partial class Form1 : Form
    {
        MySerialPort Serial = new MySerialPort(4, 9600, 0);
        private Task RunTask;//рабочий поток

        protected ManualResetEvent Suspense = new ManualResetEvent(true);//для приостановки петли измерений значений
        public Form1()
        {
            InitializeComponent();
            Serial.DataReceived += RefreshValues;
            // Serial.CommandReceived += CommandReceived;
            Serial.Write(OUTPUT_OFF);
        }

        private void buttonSetValue_Click(object sender, EventArgs e)
        {
            RunTask = Task.Run(() => SetValues());
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RunTask = Task.Run(() => WorkRepeat());
        }

        private void buttonOutput_Click(object sender, EventArgs e)
        {
            RunTask = Task.Run(() => OutputSwitch());
        }

        private void WorkRepeat()
        {
            while (true)
            {
                Serial.Write(RETURN_SET_CURRENT);
                Thread.Sleep(300);
                var curr = Serial.Read();
                textBoxGetA?.Invoke((Action)(() =>
                {
                    textBoxGetA.Text = curr.Result;
                }));
                Suspense.WaitOne();

                Serial.Write(RETURN_SET_VOLTAGE);
                Thread.Sleep(300);
                var volt = Serial.Read();
                textBoxGetV?.Invoke((Action)(() =>
                {
                    textBoxGetV.Text = volt.Result;
                }));
                Suspense.WaitOne();

                Serial.Write(RETURN_OUTPUT);
                Thread.Sleep(300);
                var output = Serial.Read();
                textBoxGetV?.Invoke((Action)(() =>
                {
                    button1.BackColor = ChangeColor(output);
                }));
                Suspense.WaitOne();
            }
        }

        Color ChangeColor(Task<string> output)
        {
            if (output.Result == "1\n")
            {
                return Color.Green;
            }
            else
            {
                return Color.Red;
            }
        }

        void OutputSwitch()
        {
            Suspense.Reset();// приостановка петли измерений значений, для отправки команды в прибор

            Serial.Write(RETURN_OUTPUT, true);
            var resieve = Serial.Read();
            Thread.Sleep(300);
            if (resieve.Result == "1\n")
            {
                Serial.Write(OUTPUT_OFF);
            }
            else if (resieve.Result == "0\n")
            {
                Serial.Write(OUTPUT_ON);
            }

            Suspense.Set();//продолить петлю измерений значений
        }



        void SetValues()
        {
            Serial.Write(SET_VOLTAGE + " " + textBoxSetV.Text);
            Serial.Write(SET_CURRENT + " " + textBoxSetA.Text);

        }
        void RefreshValues(string value)
        {
            Debug.Write(value);
        }

        private string CommandReceived()
        {
            string command = null;
            return command;
        }
    }

    public class MySerialPort
    {
        private readonly int Number;
        private readonly int BaudRate;
        private readonly int Parity;
        private GodSerialPort Serial;

        public Action<string> DataReceived;
        public Func<string, string> CommandReceived;
        public event Action<Exception> ReceiveErrorMessage;//вывод исключений

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
                try
                {
                    Serial = new GodSerialPort($"COM{Number}", BaudRate, Parity);
                    Serial.Open();
                    flag = true;
                }
                catch (Exception exception)
                {
                    throw exception;
                }
            }
        }



        public void Write(string message, bool cmd = false)
        {
            Open();
            const string END_OF_LINE = "\r\n";
            try
            {
                var dataBytes = Encoding.UTF8.GetBytes(message + END_OF_LINE);
                Serial.Write(dataBytes);
            }
            catch (Exception exception)
            {
                throw;
            }
        }

        public async Task<string> Read()
        {
            try
            {
                var dataBytes = Encoding.UTF8.GetString(Serial.Read());
                return dataBytes;
            }
            catch (Exception exception)
            {
                throw;
            }
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
                }
            }
        }



    }

    public static class CommandsSupplyPSH
    {
        public const string SET_VOLTAGE = ":chan1:volt ";
        public const string RETURN_VOLTAGE = ":chan1:meas:volt ?";
        public const string RETURN_SET_VOLTAGE = ":chan1:volt ?";

        public const string SET_CURRENT = ":chan1: curr ";
        public const string RETURN_CURRENT = ":chan1:meas:curr ?";
        public const string RETURN_SET_CURRENT = ":chan1:curr ?";

        public const string OUTPUT_ON = ":outp:stat 1";
        public const string OUTPUT_OFF = ":outp:stat 0";
        public const string RETURN_OUTPUT = ":outp:stat?";
    }
}
