
namespace ComPortTestForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSetValue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSupplyGetA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSupplyGetV = new System.Windows.Forms.TextBox();
            this.buttonOutput = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.indicatorOutput = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FineTuning = new System.Windows.Forms.CheckBox();
            this.numericUpDownSetA = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSetV = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxSetTimer = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.radioButtonMeterGetMin = new System.Windows.Forms.RadioButton();
            this.buttonStartMesaureTimer = new System.Windows.Forms.Button();
            this.radioButtonMeterGetMax = new System.Windows.Forms.RadioButton();
            this.numericUpDownRepeatTimer = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDownSetMeterH = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSetMeterS = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.lamel9 = new System.Windows.Forms.Label();
            this.numericUpDownSetMeterM = new System.Windows.Forms.NumericUpDown();
            this.buttonStopMesaureTimer = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxMeterGetMaxV = new System.Windows.Forms.TextBox();
            this.textBoxMeterGetMaxA = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxMeterGetMinV = new System.Windows.Forms.TextBox();
            this.textBoxMeterGetMinA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonStopMesaure = new System.Windows.Forms.Button();
            this.buttonStartMesaure = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMeterGetV = new System.Windows.Forms.TextBox();
            this.textBoxMeterGetA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приборовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSetA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSetV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBoxSetTimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRepeatTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSetMeterH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSetMeterS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSetMeterM)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSetValue
            // 
            this.buttonSetValue.Location = new System.Drawing.Point(7, 119);
            this.buttonSetValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSetValue.Name = "buttonSetValue";
            this.buttonSetValue.Size = new System.Drawing.Size(42, 27);
            this.buttonSetValue.TabIndex = 0;
            this.buttonSetValue.Text = "уст.";
            this.buttonSetValue.UseVisualStyleBackColor = true;
            this.buttonSetValue.Click += new System.EventHandler(this.buttonSetValue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "установить V";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "установить A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "считать A";
            // 
            // textBoxSupplyGetA
            // 
            this.textBoxSupplyGetA.Location = new System.Drawing.Point(111, 85);
            this.textBoxSupplyGetA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSupplyGetA.Name = "textBoxSupplyGetA";
            this.textBoxSupplyGetA.ReadOnly = true;
            this.textBoxSupplyGetA.Size = new System.Drawing.Size(82, 23);
            this.textBoxSupplyGetA.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "считать V";
            // 
            // textBoxSupplyGetV
            // 
            this.textBoxSupplyGetV.Location = new System.Drawing.Point(111, 40);
            this.textBoxSupplyGetV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSupplyGetV.Name = "textBoxSupplyGetV";
            this.textBoxSupplyGetV.ReadOnly = true;
            this.textBoxSupplyGetV.Size = new System.Drawing.Size(82, 23);
            this.textBoxSupplyGetV.TabIndex = 6;
            // 
            // buttonOutput
            // 
            this.buttonOutput.Location = new System.Drawing.Point(111, 119);
            this.buttonOutput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonOutput.Name = "buttonOutput";
            this.buttonOutput.Size = new System.Drawing.Size(49, 27);
            this.buttonOutput.TabIndex = 5;
            this.buttonOutput.Text = " ⍈ ";
            this.buttonOutput.UseVisualStyleBackColor = true;
            this.buttonOutput.Click += new System.EventHandler(this.buttonOutput_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRefresh.Location = new System.Drawing.Point(61, 119);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(33, 27);
            this.buttonRefresh.TabIndex = 10;
            this.buttonRefresh.Text = " ⟳";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // indicatorOutput
            // 
            this.indicatorOutput.BackColor = System.Drawing.Color.Red;
            this.indicatorOutput.Enabled = false;
            this.indicatorOutput.Location = new System.Drawing.Point(167, 119);
            this.indicatorOutput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.indicatorOutput.Name = "indicatorOutput";
            this.indicatorOutput.Size = new System.Drawing.Size(27, 27);
            this.indicatorOutput.TabIndex = 11;
            this.indicatorOutput.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FineTuning);
            this.groupBox1.Controls.Add(this.numericUpDownSetA);
            this.groupBox1.Controls.Add(this.numericUpDownSetV);
            this.groupBox1.Controls.Add(this.buttonRefresh);
            this.groupBox1.Controls.Add(this.indicatorOutput);
            this.groupBox1.Controls.Add(this.buttonSetValue);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxSupplyGetA);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxSupplyGetV);
            this.groupBox1.Controls.Add(this.buttonOutput);
            this.groupBox1.Location = new System.Drawing.Point(14, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(206, 193);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // FineTuning
            // 
            this.FineTuning.AutoSize = true;
            this.FineTuning.Location = new System.Drawing.Point(7, 157);
            this.FineTuning.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FineTuning.Name = "FineTuning";
            this.FineTuning.Size = new System.Drawing.Size(59, 19);
            this.FineTuning.TabIndex = 19;
            this.FineTuning.Text = "точно";
            this.FineTuning.UseVisualStyleBackColor = true;
            this.FineTuning.CheckedChanged += new System.EventHandler(this.FineTuning_CheckedChanged);
            // 
            // numericUpDownSetA
            // 
            this.numericUpDownSetA.DecimalPlaces = 2;
            this.numericUpDownSetA.Location = new System.Drawing.Point(7, 85);
            this.numericUpDownSetA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDownSetA.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownSetA.Name = "numericUpDownSetA";
            this.numericUpDownSetA.Size = new System.Drawing.Size(83, 23);
            this.numericUpDownSetA.TabIndex = 17;
            // 
            // numericUpDownSetV
            // 
            this.numericUpDownSetV.DecimalPlaces = 2;
            this.numericUpDownSetV.Location = new System.Drawing.Point(7, 40);
            this.numericUpDownSetV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDownSetV.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownSetV.Name = "numericUpDownSetV";
            this.numericUpDownSetV.Size = new System.Drawing.Size(83, 23);
            this.numericUpDownSetV.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBoxSetTimer);
            this.groupBox2.Controls.Add(this.buttonStopMesaureTimer);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBoxMeterGetMaxV);
            this.groupBox2.Controls.Add(this.textBoxMeterGetMaxA);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxMeterGetMinV);
            this.groupBox2.Controls.Add(this.textBoxMeterGetMinA);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.buttonStopMesaure);
            this.groupBox2.Controls.Add(this.buttonStartMesaure);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxMeterGetV);
            this.groupBox2.Controls.Add(this.textBoxMeterGetA);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(227, 33);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(490, 193);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBoxSetTimer
            // 
            this.groupBoxSetTimer.Controls.Add(this.label13);
            this.groupBoxSetTimer.Controls.Add(this.radioButtonMeterGetMin);
            this.groupBoxSetTimer.Controls.Add(this.buttonStartMesaureTimer);
            this.groupBoxSetTimer.Controls.Add(this.radioButtonMeterGetMax);
            this.groupBoxSetTimer.Controls.Add(this.numericUpDownRepeatTimer);
            this.groupBoxSetTimer.Controls.Add(this.label12);
            this.groupBoxSetTimer.Controls.Add(this.numericUpDownSetMeterH);
            this.groupBoxSetTimer.Controls.Add(this.numericUpDownSetMeterS);
            this.groupBoxSetTimer.Controls.Add(this.label11);
            this.groupBoxSetTimer.Controls.Add(this.lamel9);
            this.groupBoxSetTimer.Controls.Add(this.numericUpDownSetMeterM);
            this.groupBoxSetTimer.Location = new System.Drawing.Point(276, 15);
            this.groupBoxSetTimer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxSetTimer.Name = "groupBoxSetTimer";
            this.groupBoxSetTimer.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxSetTimer.Size = new System.Drawing.Size(201, 138);
            this.groupBoxSetTimer.TabIndex = 36;
            this.groupBoxSetTimer.TabStop = false;
            this.groupBoxSetTimer.Text = "настройка таймера";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(166, 27);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 15);
            this.label13.TabIndex = 35;
            this.label13.Text = "раз";
            // 
            // radioButtonMeterGetMin
            // 
            this.radioButtonMeterGetMin.AutoSize = true;
            this.radioButtonMeterGetMin.Enabled = false;
            this.radioButtonMeterGetMin.Location = new System.Drawing.Point(111, 52);
            this.radioButtonMeterGetMin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButtonMeterGetMin.Name = "radioButtonMeterGetMin";
            this.radioButtonMeterGetMin.Size = new System.Drawing.Size(46, 19);
            this.radioButtonMeterGetMin.TabIndex = 33;
            this.radioButtonMeterGetMin.Text = "min";
            this.radioButtonMeterGetMin.UseVisualStyleBackColor = true;
            // 
            // buttonStartMesaureTimer
            // 
            this.buttonStartMesaureTimer.Location = new System.Drawing.Point(7, 105);
            this.buttonStartMesaureTimer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonStartMesaureTimer.Name = "buttonStartMesaureTimer";
            this.buttonStartMesaureTimer.Size = new System.Drawing.Size(188, 25);
            this.buttonStartMesaureTimer.TabIndex = 30;
            this.buttonStartMesaureTimer.Text = "Timer ▶";
            this.buttonStartMesaureTimer.UseVisualStyleBackColor = true;
            this.buttonStartMesaureTimer.Click += new System.EventHandler(this.buttonStartMesaureTimer_Click);
            // 
            // radioButtonMeterGetMax
            // 
            this.radioButtonMeterGetMax.AutoSize = true;
            this.radioButtonMeterGetMax.Checked = true;
            this.radioButtonMeterGetMax.Location = new System.Drawing.Point(110, 78);
            this.radioButtonMeterGetMax.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButtonMeterGetMax.Name = "radioButtonMeterGetMax";
            this.radioButtonMeterGetMax.Size = new System.Drawing.Size(48, 19);
            this.radioButtonMeterGetMax.TabIndex = 32;
            this.radioButtonMeterGetMax.TabStop = true;
            this.radioButtonMeterGetMax.Text = "max";
            this.radioButtonMeterGetMax.UseVisualStyleBackColor = true;
            // 
            // numericUpDownRepeatTimer
            // 
            this.numericUpDownRepeatTimer.Location = new System.Drawing.Point(97, 22);
            this.numericUpDownRepeatTimer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDownRepeatTimer.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownRepeatTimer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRepeatTimer.Name = "numericUpDownRepeatTimer";
            this.numericUpDownRepeatTimer.Size = new System.Drawing.Size(62, 23);
            this.numericUpDownRepeatTimer.TabIndex = 34;
            this.numericUpDownRepeatTimer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(76, 80);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 15);
            this.label12.TabIndex = 29;
            this.label12.Text = "с";
            // 
            // numericUpDownSetMeterH
            // 
            this.numericUpDownSetMeterH.Location = new System.Drawing.Point(7, 22);
            this.numericUpDownSetMeterH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDownSetMeterH.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownSetMeterH.Name = "numericUpDownSetMeterH";
            this.numericUpDownSetMeterH.Size = new System.Drawing.Size(62, 23);
            this.numericUpDownSetMeterH.TabIndex = 20;
            this.numericUpDownSetMeterH.ValueChanged += new System.EventHandler(this.numericUpDownSetMeterH_ValueChanged);
            // 
            // numericUpDownSetMeterS
            // 
            this.numericUpDownSetMeterS.Location = new System.Drawing.Point(7, 75);
            this.numericUpDownSetMeterS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDownSetMeterS.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownSetMeterS.Name = "numericUpDownSetMeterS";
            this.numericUpDownSetMeterS.Size = new System.Drawing.Size(62, 23);
            this.numericUpDownSetMeterS.TabIndex = 26;
            this.numericUpDownSetMeterS.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownSetMeterS.ValueChanged += new System.EventHandler(this.numericUpDownSetMeterS_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(77, 53);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 15);
            this.label11.TabIndex = 28;
            this.label11.Text = "м";
            // 
            // lamel9
            // 
            this.lamel9.AutoSize = true;
            this.lamel9.Location = new System.Drawing.Point(76, 27);
            this.lamel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lamel9.Name = "lamel9";
            this.lamel9.Size = new System.Drawing.Size(14, 15);
            this.lamel9.TabIndex = 27;
            this.lamel9.Text = "ч";
            // 
            // numericUpDownSetMeterM
            // 
            this.numericUpDownSetMeterM.Location = new System.Drawing.Point(7, 48);
            this.numericUpDownSetMeterM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDownSetMeterM.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownSetMeterM.Name = "numericUpDownSetMeterM";
            this.numericUpDownSetMeterM.Size = new System.Drawing.Size(62, 23);
            this.numericUpDownSetMeterM.TabIndex = 25;
            this.numericUpDownSetMeterM.ValueChanged += new System.EventHandler(this.numericUpDownSetMeterM_ValueChanged);
            // 
            // buttonStopMesaureTimer
            // 
            this.buttonStopMesaureTimer.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.buttonStopMesaureTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStopMesaureTimer.Location = new System.Drawing.Point(284, 159);
            this.buttonStopMesaureTimer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonStopMesaureTimer.Name = "buttonStopMesaureTimer";
            this.buttonStopMesaureTimer.Size = new System.Drawing.Size(188, 25);
            this.buttonStopMesaureTimer.TabIndex = 35;
            this.buttonStopMesaureTimer.Text = "Timer █";
            this.buttonStopMesaureTimer.UseVisualStyleBackColor = true;
            this.buttonStopMesaureTimer.Click += new System.EventHandler(this.buttonStopMesaureTimer_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(187, 66);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "max A";
            // 
            // textBoxMeterGetMaxV
            // 
            this.textBoxMeterGetMaxV.Location = new System.Drawing.Point(187, 39);
            this.textBoxMeterGetMaxV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxMeterGetMaxV.Name = "textBoxMeterGetMaxV";
            this.textBoxMeterGetMaxV.ReadOnly = true;
            this.textBoxMeterGetMaxV.Size = new System.Drawing.Size(82, 23);
            this.textBoxMeterGetMaxV.TabIndex = 21;
            // 
            // textBoxMeterGetMaxA
            // 
            this.textBoxMeterGetMaxA.Location = new System.Drawing.Point(187, 85);
            this.textBoxMeterGetMaxA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxMeterGetMaxA.Name = "textBoxMeterGetMaxA";
            this.textBoxMeterGetMaxA.ReadOnly = true;
            this.textBoxMeterGetMaxA.Size = new System.Drawing.Size(82, 23);
            this.textBoxMeterGetMaxA.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(187, 21);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "max V";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 66);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "min A";
            // 
            // textBoxMeterGetMinV
            // 
            this.textBoxMeterGetMinV.Location = new System.Drawing.Point(97, 39);
            this.textBoxMeterGetMinV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxMeterGetMinV.Name = "textBoxMeterGetMinV";
            this.textBoxMeterGetMinV.ReadOnly = true;
            this.textBoxMeterGetMinV.Size = new System.Drawing.Size(82, 23);
            this.textBoxMeterGetMinV.TabIndex = 17;
            // 
            // textBoxMeterGetMinA
            // 
            this.textBoxMeterGetMinA.Location = new System.Drawing.Point(97, 85);
            this.textBoxMeterGetMinA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxMeterGetMinA.Name = "textBoxMeterGetMinA";
            this.textBoxMeterGetMinA.ReadOnly = true;
            this.textBoxMeterGetMinA.Size = new System.Drawing.Size(82, 23);
            this.textBoxMeterGetMinA.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(97, 21);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "min V";
            // 
            // buttonStopMesaure
            // 
            this.buttonStopMesaure.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStopMesaure.Location = new System.Drawing.Point(56, 120);
            this.buttonStopMesaure.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonStopMesaure.Name = "buttonStopMesaure";
            this.buttonStopMesaure.Size = new System.Drawing.Size(34, 25);
            this.buttonStopMesaure.TabIndex = 16;
            this.buttonStopMesaure.Text = "█";
            this.buttonStopMesaure.UseVisualStyleBackColor = true;
            this.buttonStopMesaure.Click += new System.EventHandler(this.buttonStopMesaure_Click);
            // 
            // buttonStartMesaure
            // 
            this.buttonStartMesaure.Location = new System.Drawing.Point(7, 120);
            this.buttonStartMesaure.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonStartMesaure.Name = "buttonStartMesaure";
            this.buttonStartMesaure.Size = new System.Drawing.Size(42, 25);
            this.buttonStartMesaure.TabIndex = 12;
            this.buttonStartMesaure.Text = "▶";
            this.buttonStartMesaure.UseVisualStyleBackColor = true;
            this.buttonStartMesaure.Click += new System.EventHandler(this.buttonStartMesaure_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "считать A";
            // 
            // textBoxMeterGetV
            // 
            this.textBoxMeterGetV.Location = new System.Drawing.Point(7, 40);
            this.textBoxMeterGetV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxMeterGetV.Name = "textBoxMeterGetV";
            this.textBoxMeterGetV.ReadOnly = true;
            this.textBoxMeterGetV.Size = new System.Drawing.Size(82, 23);
            this.textBoxMeterGetV.TabIndex = 12;
            // 
            // textBoxMeterGetA
            // 
            this.textBoxMeterGetA.Location = new System.Drawing.Point(7, 87);
            this.textBoxMeterGetA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxMeterGetA.Name = "textBoxMeterGetA";
            this.textBoxMeterGetA.ReadOnly = true;
            this.textBoxMeterGetA.Size = new System.Drawing.Size(82, 23);
            this.textBoxMeterGetA.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "считать V";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(729, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comPortToolStripMenuItem,
            this.приборовToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // comPortToolStripMenuItem
            // 
            this.comPortToolStripMenuItem.Name = "comPortToolStripMenuItem";
            this.comPortToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.comPortToolStripMenuItem.Text = "com port";
            // 
            // приборовToolStripMenuItem
            // 
            this.приборовToolStripMenuItem.Name = "приборовToolStripMenuItem";
            this.приборовToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.приборовToolStripMenuItem.Text = "приборов";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 232);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSetA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSetV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxSetTimer.ResumeLayout(false);
            this.groupBoxSetTimer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRepeatTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSetMeterH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSetMeterS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSetMeterM)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSetValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSupplyGetA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSupplyGetV;
        private System.Windows.Forms.Button buttonOutput;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button indicatorOutput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonStartMesaure;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMeterGetV;
        private System.Windows.Forms.TextBox textBoxMeterGetA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownSetV;
        private System.Windows.Forms.NumericUpDown numericUpDownSetA;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem приборовToolStripMenuItem;
        private System.Windows.Forms.Button buttonStopMesaure;
        private System.Windows.Forms.CheckBox FineTuning;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lamel9;
        private System.Windows.Forms.NumericUpDown numericUpDownSetMeterS;
        private System.Windows.Forms.NumericUpDown numericUpDownSetMeterM;
        private System.Windows.Forms.NumericUpDown numericUpDownSetMeterH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxMeterGetMaxV;
        private System.Windows.Forms.TextBox textBoxMeterGetMaxA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxMeterGetMinV;
        private System.Windows.Forms.Label label8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonStartMesaureTimer;
        private System.Windows.Forms.RadioButton radioButtonMeterGetMin;
        private System.Windows.Forms.RadioButton radioButtonMeterGetMax;
        private System.Windows.Forms.NumericUpDown numericUpDownRepeatTimer;
        private System.Windows.Forms.TextBox textBoxMeterGetMinA;
        private System.Windows.Forms.Button buttonStopMesaureTimer;
        private System.Windows.Forms.GroupBox groupBoxSetTimer;
        private System.Windows.Forms.Label label13;
    }
}

