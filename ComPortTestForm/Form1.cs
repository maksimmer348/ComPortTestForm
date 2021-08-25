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
using GodSharp.SerialPort.Enums;
using static ComPortTestForm.CommandsSupplyPSH;

namespace ComPortTestForm
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            //
            //
            SerialSupply.Open();
            SerialSupply.Write(OUTPUT_OFF);
            Thr = Task.Run(() => WorkRepeat());
            outputOn = false;
            //
            //


        }

        #region Supply

        MySerialPort SerialSupply = new MySerialPort(21, 57600, 0);
        private static Mutex mutSupply = new Mutex();
        private Task Thr;
        private bool outputOn;
        protected ManualResetEvent SuspenseSupply = new ManualResetEvent(true);//для приостановки петли измерений значений
        protected ManualResetEvent WaitSuspenseThread = new ManualResetEvent(true);

        private async void buttonSetValue_Click(object sender, EventArgs e)
        {
            ((Button)sender).Enabled = false;
            await Task.Run(SetValues);
            ((Button)sender).Enabled = true;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {

        }

        private async void buttonOutput_Click(object sender, EventArgs e)
        {
            ((Button)sender).Enabled = false;
            await Task.Run(OutputSwitch);
            ((Button)sender).Enabled = true;
        }

        private void WorkRepeat()
        {
            while (true)
            {
                //
                //
                {
                    SerialSupply.Write(RETURN_OUTPUT);
                    Thread.Sleep(300);//300
                    //
                    var output = SerialSupply.Read();
                    textBoxGetV?.Invoke((Action)(() => button1.BackColor = ChangeColor(output)));
                }
                //
                //
                {
                    SerialSupply.Write(RETURN_SET_VOLTAGE);
                    Thread.Sleep(300);
                    //
                    var value = SerialSupply.Read();
                    textBoxGetV?.Invoke((Action)(() => textBoxGetV.Text = value));
                }
                //
                //
                {
                    SerialSupply.Write(RETURN_SET_CURRENT);
                    Thread.Sleep(300);
                    //
                    var value = SerialSupply.Read();
                    textBoxGetA?.Invoke((Action)(() => textBoxGetA.Text = value));
                }
                WaitSuspenseThread.Set();
                //Debug.WriteLine("loop wait");
                SuspenseSupply.WaitOne();
                //Debug.WriteLine("loop continue");
                WaitSuspenseThread.Reset();
                //
                //
            }
        }

        Color ChangeColor(string output)
        {
            return output == "1\n" ? Color.Green : Color.Red;
        }

        void OutputSwitch()
        {
            mutSupply.WaitOne();

            //Debug.WriteLine("OutputSwitch start");
            SuspenseSupply.Reset();// приостановка пеи измерений значений, для отправки команды в прибор
            WaitSuspenseThread.WaitOne();
            //Debug.WriteLine("OutputSwitch continue");
            if (checkBoxOutputType.Checked)
            {
                SerialSupply.Write(RETURN_OUTPUT);
                Thread.Sleep(100);

                var result = SerialSupply.Read();

                if (result == "1\n")
                {
                    SerialSupply.Write(OUTPUT_OFF);
                }
                else if (result == "0\n")
                {
                    SerialSupply.Write(OUTPUT_ON);
                }
            }

            else if (!checkBoxOutputType.Checked)
            {
                outputOn = !outputOn;
                if (outputOn)
                {
                    SerialSupply.Write(OUTPUT_OFF);
                }
                else if (!outputOn)
                {
                    SerialSupply.Write(OUTPUT_ON);
                }
            }

            //Debug.WriteLine("OutputSwitch end");
            SuspenseSupply.Set();//продолить петлю измерений значений
            mutSupply.ReleaseMutex();
        }



        void SetValues()
        {
            mutSupply.WaitOne();

            //Debug.WriteLine("SetValues start");
            SuspenseSupply.Reset();
            WaitSuspenseThread.WaitOne();
            //Debug.WriteLine("SetValues continue");

            SerialSupply.Write(SET_VOLTAGE + " " + textBoxSetV.Text);
            SerialSupply.Write(SET_CURRENT + " " + textBoxSetA.Text);

            //Debug.WriteLine("SetValues end");
            SuspenseSupply.Set();//продолить петлю измерений значений

            mutSupply.ReleaseMutex();
        }
        private void checkBoxOutputType_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion


    }

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
    public static class CommandsSupplyGw
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
