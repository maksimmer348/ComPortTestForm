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

        private Thread thr;

        private void buttonSetValue_Click(object sender, EventArgs e)
        {
            thr = new Thread(SetValues);
            thr.Start();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            thr = new Thread(WorkRepeat);
            thr.Start();
           
        }

        private void buttonOutput_Click(object sender, EventArgs e)
        {
            thr = new Thread(OutputSwitch);
            thr.Start();
        }

        private void WorkRepeat()
        {
            while (true)
            {
                Serial.Write(RETURN_SET_CURRENT);
                Thread.Sleep(150);
                var curr = Serial.Read();
                Suspense.WaitOne();
                textBoxGetA?.Invoke((Action)(() =>
                {
                    textBoxGetA.Text = curr;
                }));
                
                Serial.Write(RETURN_SET_VOLTAGE);
                Thread.Sleep(150);
                var volt = Serial.Read();
                Suspense.WaitOne();
                textBoxGetV?.Invoke((Action)(() =>
                {
                    textBoxGetV.Text = volt;
                }));
                

                //Serial.Write(RETURN_OUTPUT);
                //Thread.Sleep(50);
                //textBoxGetV?.Invoke((Action)(() =>
                //{
                //    textBoxGetV.Text = Serial.Read();
                //}));
                //Thread.Sleep(50);
                //Suspense.WaitOne();
            }
        }

        void OutputSwitch()
        {
            Suspense.Reset();// приостановка петли измерений значений, для отправки команды в прибор
            if (Serial.IsReady)
            {
                Thread.Sleep(150);
                var output = Serial.Write(RETURN_OUTPUT, true);

                if (output == "1\n")
                {
                    Serial.Write(OUTPUT_OFF);
                }
                else if (output == "0\n")
                {
                    Serial.Write(OUTPUT_ON);
                }
                
            }
            Suspense.Set();//продолить петлю измерений значений
        }



        void SetValues()
        {
            if (Serial.IsReady)
            {
                Serial.Write(SET_VOLTAGE + " " + textBoxSetV.Text);
                Serial.Write(SET_CURRENT + " " + textBoxSetA.Text);
            }
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



        public string Write(string message, bool cmd = false)
        {
            IsReady = false;
            Open();
            const string END_OF_LINE = "\r\n";
            try
            {
                var dataBytes = Encoding.UTF8.GetBytes(message + END_OF_LINE);
                Serial.Write(dataBytes);
                if (cmd)
                {
                    Thread.Sleep(200);
                    IsReady = true;
                    return Read();
                }
                IsReady = true;
                return null;
            }
            catch (Exception exception)
            {
                throw;
            }
        }

        public bool IsReady { get; set; }

        public string Read()
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
