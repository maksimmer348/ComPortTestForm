using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Text.RegularExpressions;
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
           
            //
            //
            //
            SerialMeterCurr.Open();
            SerialMeterVolt.Open();
            //
            buttonStopMesaure.Enabled = false;
            //
            //
            Task.Run(() =>  Start());
        }
        private void Form1_Load(object sender, System.EventArgs e)
        {
           
        }
        #region Supply

        MySerialPort SerialSupply = new MySerialPort(21, 57600, 0);
        private static Mutex mutSupply = new Mutex();
        protected ManualResetEvent SuspenseSupply = new ManualResetEvent(true);//для приостановки петли измерений значений
        protected ManualResetEvent WaitSuspenseThread = new ManualResetEvent(true);//ожидает выполнения потока, дабы они не перемешивались

        void Start()
        {

            SerialSupply.Write(RETURN_SET_VOLTAGE);
            Thread.Sleep(50);
            numericUpDownSetV?.Invoke((Action)(() => numericUpDownSetV.Value =
                Regex.Matches(SerialSupply.Read(), @"(\d+(?:\.\d+)?)").OfType<Match>()
                    .Select(num => decimal.Parse(num.Value.Replace(".", ","))).Last()));

            SerialSupply.Write(RETURN_SET_CURRENT);
            Thread.Sleep(50);
            numericUpDownSetV?.Invoke((Action)(() => numericUpDownSetA.Value =
                Regex.Matches(SerialSupply.Read(), @"(\d+(?:\.\d+)?)").OfType<Match>()
                    .Select(num => decimal.Parse(num.Value.Replace(".", ","))).Last()));

            buttonRefresh?.Invoke((Action)(() => buttonRefresh.PerformClick()));
        }

        private async void buttonSetValue_Click(object sender, EventArgs e)
        {
            ((Button)sender).Enabled = false;
            await Task.Run(SetValues);
            ((Button)sender).Enabled = true;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            ((Button)sender).Enabled = false;
            Task.Run(() => WorkRepeatSupply());
        }

        private async void buttonOutput_Click(object sender, EventArgs e)
        {
            ((Button)sender).Enabled = false;
            await Task.Run(OutputSwitch);
            ((Button)sender).Enabled = true;
        }

        private void WorkRepeatSupply()
        {
            var unnecessary = new[] { '?', '\n', '\r', '+' };

            while (true)
            {
                //
                //
                {
                    SerialSupply.Write(RETURN_OUTPUT);
                    Thread.Sleep(50);
                    //
                    var value = SerialSupply.Read();
                    textBoxSupplyGetV?.Invoke((Action)(() => indicatorOutput.BackColor = ChangeColor(value)));
                }
                //
                //
                {
                    SerialSupply.Write(RETURN_VOLTAGE);
                    Thread.Sleep(50);
                    //
                    var value = SerialSupply.Read();
                    var temp = String.Join("", value.Where((ch) => !unnecessary.Contains(ch)));
                    textBoxSupplyGetV?.Invoke((Action)(() => textBoxSupplyGetV.Text = temp));
                }
                //
                //
                {
                    SerialSupply.Write(RETURN_CURRENT);
                    Thread.Sleep(50);
                    //
                    var value = SerialSupply.Read();
                    var temp = String.Join("", value.Where((ch) => !unnecessary.Contains(ch)));
                    textBoxSupplyGetA?.Invoke((Action)(() => textBoxSupplyGetA.Text = temp));
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

            SerialSupply.Write(RETURN_OUTPUT);
            Thread.Sleep(50);

            var result = SerialSupply.Read();

            if (result == "1\n")
            {
                SerialSupply.Write(OUTPUT_OFF);
            }
            else if (result == "0\n")
            {
                SerialSupply.Write(OUTPUT_ON);
            }

            //Debug.WriteLine("OutputSwitch end");
            SuspenseSupply.Set();//продолить петлю измерений значений
            mutSupply.ReleaseMutex();
        }

        void SetValues()
        {
            mutSupply.WaitOne();

            //Debug.WriteLine("SetValues star,t");
            SuspenseSupply.Reset();
            WaitSuspenseThread.WaitOne();
            //Debug.WriteLine("SetValues continue");

            SerialSupply.Write(SET_VOLTAGE + " " + numericUpDownSetV.Text.Replace(",", "."));
            SerialSupply.Write(SET_CURRENT + " " + numericUpDownSetA.Text.Replace(",", "."));
            //Thread.Sleep(50);
            //SerialSupply.Write(RETURN_OUTPUT);

            //Debug.WriteLine("SetValues end");
            SuspenseSupply.Set();//продолить петлю измерений значений

            mutSupply.ReleaseMutex();
        }

        void SwitchPrecisionModes()
        {
            if (FineTuning.Checked)
            {
                numericUpDownSetV.Increment = 0.01m;
                numericUpDownSetA.Increment = 0.01m;
            }
            else
            {
                numericUpDownSetV.Increment = 1;
                numericUpDownSetA.Increment = 1;
            }
        }

        private void FineTuning_CheckedChanged(object sender, EventArgs e)
        {
            SwitchPrecisionModes();
        }


        #endregion

        #region meter

        MySerialPort SerialMeterVolt  = new MySerialPort(22, 57600, 0);
        MySerialPort SerialMeterCurr =new MySerialPort(19, 57600, 0); 
        CancellationToken token;

        private CancellationTokenSource source;
        //private static Mutex mutMeter = new Mutex();

        protected ManualResetEvent SuspenseMeter = new ManualResetEvent(true);//для приостановки петли измерений значений
        protected ManualResetEvent WaitSuspenseThreadMeter = new ManualResetEvent(true);//ожидает выполнения потока, дабы они не перемешивались

        private void buttonStartMesaure_Click(object sender, EventArgs e)
        {
            source = new CancellationTokenSource();
            buttonStartMesaure.Enabled = false;
            buttonStopMesaure.Enabled = true;
            token = source.Token;
            Task.Run(() => WorkRepeatMeter(), token);
        }
        private void buttonStopMesaure_Click(object sender, EventArgs e)
        {
            buttonStartMesaure.Enabled = true;
            buttonStopMesaure.Enabled = false;
            source?.Cancel();
        }




        private void WorkRepeatMeter()
        {
            var unnecessary = new[] { '?', '\n', '\r', '+', 'E' };

            while (!token.IsCancellationRequested)
            {
                //
                //
                {

                    SerialMeterVolt.Write(CommandsMeterGDM.RETURN_VOLTAGE);
                    Thread.Sleep(200);
                    //
                    var value = SerialMeterVolt.Read();
                    var temp = String.Join("", value.Where((ch) => !unnecessary.Contains(ch)));
                    textBoxSupplyGetV?.Invoke((Action)(() => textBoxMeterGetV.Text = temp));
                }
                //
                //
                {
                    SerialMeterCurr.Write(CommandsMeterGDM.RETURN_CURRENT);
                    Thread.Sleep(200);
                    //
                    var value = SerialMeterCurr.Read();
                    var temp = String.Join("", value.Where((ch) => !unnecessary.Contains(ch)));
                    textBoxSupplyGetV?.Invoke((Action)(() => textBoxMeterGetA.Text = temp));
                }
                //
                //

                WaitSuspenseThreadMeter.Set();

                //Debug.WriteLine("loop wait");

                SuspenseMeter.WaitOne();

                //Debug.WriteLine("loop continue");

                WaitSuspenseThreadMeter.Reset();

                //
                //
            }
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

    public static class CommandsSupplyGw //CommandsSupplyPSH
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
    public static class CommandsSupplyPSH //CommandsSupplyGw
    {
        public const string SET_VOLTAGE = "SOUR:VOLT:LEV:IMM:AMPL ";
        public const string RETURN_VOLTAGE = "MEASure:VOLTage?";
        public const string RETURN_SET_VOLTAGE = "SOUR:VOLT:LEV:IMM:AMPL?";

        public const string SET_CURRENT = "SOUR:CURR:LEV:IMM:AMPL ";
        public const string RETURN_CURRENT = "MEASure:CURRent?";
        public const string RETURN_SET_CURRENT = "SOUR:CURR:LEV:IMM:AMPL?";

        public const string OUTPUT_ON = "OUTPut:STATe 1";
        public const string OUTPUT_OFF = "OUTPut:STATe 0";
        public const string RETURN_OUTPUT = "OUTPut:STATe?";
    }
    public static class CommandsMeterGDM //CommandsSupplyGw
    {
        //public const string SET_VOLTAGE = "SOUR:VOLT:LEV:IMM:AMPL ";
        //public const string SET_VOLTAGE_RANGE = "SOUR:VOLT:LEV:IMM:AMPL?";
        public const string RETURN_VOLTAGE = "MEAS:VOLT:DC? 50";

        //public const string SET_CURRENT = "SOUR:CURR:LEV:IMM:AMPL ";
        //public const string SET_CURRENTE_RANGE = "SOUR:CURR:LEV:IMM:AMPL?";
        public const string RETURN_CURRENT = "MEAS:CURR:DC? 10" ;

        public const string SET_CALCULATE_MIN = "CALCulate:FUNCtion MIN";
        public const string GET_CALCULATE_MIN = "CALCulate:MINimum?";

        public const string SET_CALCULATE_MAX = "CALCulate:FUNCtion MAX";
        public const string GET_CALCULATE_MAX = "CALCulate:MAXimum?";

        public const string GET_CALCULATE_MODE = "CALCulate:FUNCtion?";
        

        
    }
}
