using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GodSharp.SerialPort;
using GodSharp.SerialPort.Enums;
using static ComPortTestForm.CommandsSupplyPSH;
using Timer = System.Windows.Forms.Timer;

namespace ComPortTestForm
{
    public partial class Form1 : Form
    {
        #region Ctor & Init

        //TODO добавить класс поиска( ComPort.Write("*IDN?");) и инициализации приборов по полученным id => GWInstek,GDM78341,GEP844336,1.03
        //TODO 
        //TODO
        //TODO
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
            Task.Run(() => Start());
        }
        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        #endregion


        #region Supply

        MySerialPort SerialSupply = new MySerialPort(21, 57600, 0);

        private static Mutex mutSupply = new Mutex();//взаимное исключение потоков кнопок наличие эксклюзивного владельца, который и должен его освобождать 
        protected ManualResetEvent SuspenseSupply = new ManualResetEvent(true);//для приостановки петли измерений значений
        protected ManualResetEvent WaitSuspenseThread = new ManualResetEvent(true);//ожидает выполнения потока, дабы они не перемешивались

        //TODO перенести и унифицировать все мтоды Regex.Matches в единый метод 
        //TODO buttonRefresh?.Invoke((Action)(() => buttonRefresh.PerformClick())); заменить на вызов метода

        void Start()//метод первичной инициализации
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


        #region control buttons

        private async void buttonSetValue_Click(object sender, EventArgs e)//установка занчений в блок питания(напряжение и ток)
        {
            ((Button)sender).Enabled = false;//отключаем кнопку на время выполнения всех команд
            await Task.Run(SetValues);
            ((Button)sender).Enabled = true;
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


        private async void buttonOutput_Click(object sender, EventArgs e)
        {
            ((Button)sender).Enabled = false;
            await Task.Run(OutputSwitch);
            ((Button)sender).Enabled = true;
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

        #endregion

        #region measurement loop 

        private void buttonRefresh_Click(object sender, EventArgs e)//обновление значений
        {
            ((Button)sender).Enabled = false;//отключаем кнопку на время выполнения программы
            Task.Run(WorkRepeatSupply);
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

        #endregion

        #region view
        Color ChangeColor(string output)//смена цвета для индикации output
        {
            return output == "1\n" ? Color.Green : Color.Red;
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

        #endregion


        #region Meter

        MySerialPort SerialMeterVolt = new MySerialPort(22, 57600, 0);
        MySerialPort SerialMeterCurr = new MySerialPort(19, 57600, 0);

        CancellationToken TokenLoopMeter;//для остановки птели измерений
        private CancellationTokenSource SourceLoopMeter;//для остановки птели измерений

        CancellationToken TokenMinMaxMeter;//для остановки птели измерений
        private CancellationTokenSource SourceMinMaxMeter;//для остановки птели измерений

        private static Mutex mutMeter = new Mutex();//во избежание пересения потоко кнопок
        protected ManualResetEvent SuspenseMeter = new ManualResetEvent(true);//для приостановки петли измерений значений
        protected ManualResetEvent WaitSuspenseThreadMeter = new ManualResetEvent(true);//ожидает выполнения потока, дабы они не перемешивались
        protected ManualResetEvent ThreadPause = new ManualResetEvent(false);

       

        #region measurement loop

        private void buttonStartMesaure_Click(object sender, EventArgs e)//запуск петли измерений
        {
            SourceLoopMeter = new CancellationTokenSource();
            ((Button)sender).Enabled = false;//отключаем эту кнопку
            buttonStopMesaure.Enabled = true;//включаем кнопку остановки плеи измерений
            TokenLoopMeter = SourceLoopMeter.Token;//для запуска петли
            Task.Run(() => WorkRepeatMeter(), TokenLoopMeter);
        }
        private void buttonStopMesaure_Click(object sender, EventArgs e)//отановка петли измерений
        {
            buttonStartMesaure.Enabled = true;//включаем кнопку запуска плеи измерений
            ((Button)sender).Enabled = false;//отключаем эту кнопку
            SourceLoopMeter?.Cancel();//останавлиаем петли имзерений (2)
        }

        //TODO перенсти var temp = String.Join("", value.Where((ch) => !unnecessary.Contains(ch))); отсюда обратно в компорт
        //TODO  var unnecessary = new[] { '?', '\n', '\r', '+', 'E' }; отсюда обратно в компорт
        //TODO Thread.Sleep(200); перенести и унифицировать например добавить в своййство write по умолчанию 50 мс
        //TODO  textBoxSupplyGetV?.Invoke((Action)(() => textBoxMeterGetA.Text = temp)); создать метод 
        private void WorkRepeatMeter()//петля измерений
        {
            var unnecessary = new[] { '?', '\n', '\r', '+', 'E' };//шаблонудаляемых элементов из входной строки

            while (!TokenLoopMeter.IsCancellationRequested)//для остановкеи петли измерений через кнопку (2)
            {
                //
                //
                {
                    SerialMeterVolt.Write(CommandsMeterGDM.RETURN_VOLTAGE);//команда запрос напряжения с вольтметра
                    Thread.Sleep(200);
                    //
                    var value = SerialMeterVolt.Read();
                    var temp = String.Join("", value.Where((ch) => !unnecessary.Contains(ch)));
                    textBoxSupplyGetV?.Invoke((Action)(() => textBoxMeterGetV.Text = temp));
                }
                //
                //
                {
                    SerialMeterCurr.Write(CommandsMeterGDM.RETURN_CURRENT);//команда запрос тока с амперметра
                    Thread.Sleep(200);
                    //
                    var value = SerialMeterCurr.Read();
                    var temp = String.Join("", value.Where((ch) => !unnecessary.Contains(ch)));
                    textBoxSupplyGetV?.Invoke((Action)(() => textBoxMeterGetA.Text = temp));
                }
                //
                //
                WaitSuspenseThreadMeter.Set();//команда выполнена можно отпускать поток там(1)
                //Debug.WriteLine("loop wait");
                SuspenseMeter.WaitOne();//для оатсновки птели измерений кнопками
                //Debug.WriteLine("loop continue");
                WaitSuspenseThreadMeter.Reset();//начинаем петлю измерений блокуирем потоки кнопок до его отпуска в (1)
                //
                //
            }
        }

        #endregion

        #region measurement timer 

        Stopwatch Clock = new Stopwatch();//отладочный секундомер

        private void GetMaxValueMeter(decimal loop = 1, int pause = 0)
        {
            int countLoop = 1;
            while (!TokenMinMaxMeter.IsCancellationRequested)
            {
                SuspenseMeter.Reset();// приостановка пеи измерений значений, для отправки команды в прибор
                WaitSuspenseThreadMeter.WaitOne();

                SerialMeterVolt.Write(CommandsMeterGDM.SET_CALCULATE_MODE_OFF);
                SerialMeterCurr.Write(CommandsMeterGDM.SET_CALCULATE_MODE_OFF);
                
                SerialMeterVolt.Write(CommandsMeterGDM.SET_CALCULATE_MAX);
                SerialMeterCurr.Write(CommandsMeterGDM.SET_CALCULATE_MAX);
                //
                ThreadPause.WaitOne(pause);
                //
                SerialMeterVolt.Write(CommandsMeterGDM.GET_CALCULATE_MAX);
                SerialMeterCurr.Write(CommandsMeterGDM.GET_CALCULATE_MAX);

                Clock.Stop();
                Debug.Write(Clock.Elapsed);

                Thread.Sleep(50);

                var unnecessary = new[] { '?', '\n', '\r', '+', 'E' };

                var resultVolt = SerialMeterVolt.Read();
                var tempV = String.Join("", resultVolt.Where((ch) => !unnecessary.Contains(ch)));
                textBoxMeterGetMaxV?.Invoke((Action)(() => textBoxMeterGetMaxV.Text = tempV));

                var resultCurr = SerialMeterCurr.Read();
                var tempC = String.Join("", resultCurr.Where((ch) => !unnecessary.Contains(ch)));
                textBoxMeterGetMaxA?.Invoke((Action)(() => textBoxMeterGetMaxA.Text = tempC));

                SuspenseMeter.Set();//продолить петлю измерений значений

                if (countLoop >= loop)
                {
                    SourceMinMaxMeter?.Cancel();
                }
                countLoop += 1;
            }
        }
        private void GetMinValueMeter(decimal loop = 1, int pause = 0)
        {
            int countLoop = 1;
            while (!TokenMinMaxMeter.IsCancellationRequested)
            {
                SuspenseMeter.Reset(); // приостановка пеи измерений значений, для отправки команды в прибор
                WaitSuspenseThreadMeter.WaitOne();

                SerialMeterVolt.Write(CommandsMeterGDM.SET_CALCULATE_MODE_OFF);
                SerialMeterCurr.Write(CommandsMeterGDM.SET_CALCULATE_MODE_OFF);
               
                SerialMeterVolt.Write(CommandsMeterGDM.SET_CALCULATE_MIN);
                SerialMeterCurr.Write(CommandsMeterGDM.SET_CALCULATE_MIN);
                //
                SuspenseMeter.Set();
                ThreadPause.WaitOne(pause);
                SuspenseMeter.Reset();
                WaitSuspenseThreadMeter.WaitOne();
                //
                SerialMeterVolt.Write(CommandsMeterGDM.GET_CALCULATE_MIN);
                SerialMeterCurr.Write(CommandsMeterGDM.GET_CALCULATE_MIN);

                Clock.Stop();
                Debug.Write(Clock.Elapsed);
                Thread.Sleep(50);

                var unnecessary = new[] {'?', '\n', '\r', '+', 'E'};

                var resultVolt = SerialMeterVolt.Read();
                var tempV = String.Join("", resultVolt.Where((ch) => !unnecessary.Contains(ch)));
                textBoxMeterGetMaxV?.Invoke((Action) (() => textBoxMeterGetMinV.Text = tempV));

                var resultCurr = SerialMeterCurr.Read();
                var tempC = String.Join("", resultCurr.Where((ch) => !unnecessary.Contains(ch)));
                textBoxMeterGetMaxA?.Invoke((Action) (() => textBoxMeterGetMinA.Text = tempC));

                SuspenseMeter.Set(); //продолить петлю измерений значений
               
                if (countLoop >= loop)
                {
                    SourceMinMaxMeter?.Cancel();
                }
                countLoop += 1;
            }
        }

        private async void buttonStartMesaureTimer_Click(object sender, EventArgs e)
        {
            ThreadPause.Reset();
            Clock.Start();

            SourceMinMaxMeter = new CancellationTokenSource();

            TokenMinMaxMeter = SourceMinMaxMeter.Token;//для запуска петли

            ((Button)sender).Enabled = false;//отключаем кнопку на время выполнения всех команд
            groupBoxSetTimer.Enabled = false;

            int pauseDelay = SetTimer(numericUpDownSetMeterH.Value, numericUpDownSetMeterM.Value,
                numericUpDownSetMeterS.Value);
            var repeatTimer = numericUpDownRepeatTimer.Value;

            if (radioButtonMeterGetMax.Checked)
            {
                await Task.Run(() => GetMaxValueMeter(repeatTimer, pauseDelay), TokenMinMaxMeter);
            }
            if (radioButtonMeterGetMin.Checked)
            {
                await Task.Run(() => GetMinValueMeter(repeatTimer, pauseDelay), TokenMinMaxMeter);
            }

            ((Button)sender).Enabled = true;
            buttonStopMesaureTimer.Enabled = true;
            groupBoxSetTimer.Enabled = true;
        }
        
        private void buttonStopMesaureTimer_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            ((Button)sender).Enabled = false;//отключаем эту кнопку
            groupBoxSetTimer.Enabled = true;

            ThreadPause.Set();//останавлиаем петли имзерений (2)
            SourceMinMaxMeter?.Cancel();
        }

        int SetTimer(decimal h, decimal m, decimal s)
        {
            var ss = new TimeSpan((int)h, (int)m, (int)s);
            return (int)ss.TotalMilliseconds - 200;//задержка на отправк и принятие команд
        }

        #endregion

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
        public const string RETURN_CURRENT = "MEAS:CURR:DC? 10";

        public const string SET_CALCULATE_MIN = "CALCulate:FUNCtion MIN";
        public const string GET_CALCULATE_MIN = "CALCulate:MINimum?";

        public const string SET_CALCULATE_MAX = "CALCulate:FUNCtion MAX";
        public const string GET_CALCULATE_MAX = "CALCulate:MAXimum?";

        public const string GET_CALCULATE_MODE = "CALCulate:FUNCtion?";
        public const string SET_CALCULATE_MODE_OFF = "CALCulate:FUNCtion OFF";


    }
}
