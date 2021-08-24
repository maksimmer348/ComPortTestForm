using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
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

        private void WorkRepeat()
        {
            while (true)
            {
                Serial.Write(RETURN_SET_CURRENT);
                Thread.Sleep(50);
                textBoxGetA?.Invoke((Action)(() =>
                {
                    textBoxGetA.Text = Serial.Read("ток");
                }));
                Thread.Sleep(50);
                Suspense.WaitOne();

                Serial.Write(RETURN_SET_VOLTAGE);
                Thread.Sleep(50);
                textBoxGetV?.Invoke((Action)(() =>
                {
                    textBoxGetV.Text = Serial.Read("напряжение");
                }));
                Thread.Sleep(50);
                Suspense.WaitOne();

                Serial.Write(RETURN_OUTPUT);
                Thread.Sleep(50);
                Serial.Read("выход");
                Thread.Sleep(50);
                Suspense.WaitOne();
            }
        }

        private void buttonOutput_Click(object sender, EventArgs e)
        {
            RunTask = Task.Run(() => OutputSwitch());
        }

        void OutputSwitch()
        {
            Suspense.Reset();// приостановка петли измерений значений, для отправки команды в прибор
            Serial.Write(RETURN_OUTPUT);
            Thread.Sleep(50);
            Serial.Read();
            Thread.Sleep(50);
            //if ()
            //{
            //    Serial.Write(OUTPUT_OFF);
            //}
            //else if ()
            //{
            //    Serial.Write(OUTPUT_ON);
            //}
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

        public void Write(string message)
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
                throw exception;
            }
        }

        /// <summary>
        /// чтение из компорта
        /// </summary>
        /// <param name="cmd">передача команды в ответе для идентификации</param>
        /// <param name="cmdRequsetCmd"></param>
        /// <param name="command"></param>
        public string Read(string command = null)
        {
            string buffer = null;
            try
            {
                Serial.UseDataReceived(flag, (port, bytes) =>
                {
                    buffer = Encoding.UTF8.GetString(bytes);
                });
                return buffer;
            }
            catch (Exception exception)
            {
                throw exception;
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


        static string RemoveUnnecessary(string message)//удаление мусора для строки ответа
        {
            var unnecessary = new[] { '?', '\n', '\r' };
            return String.Join("", message.Where((ch) => !unnecessary.Contains(ch)));
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
