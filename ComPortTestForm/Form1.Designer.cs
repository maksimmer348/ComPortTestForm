
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
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.lamel9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSetA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSetV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSetValue
            // 
            this.buttonSetValue.Location = new System.Drawing.Point(6, 100);
            this.buttonSetValue.Name = "buttonSetValue";
            this.buttonSetValue.Size = new System.Drawing.Size(36, 23);
            this.buttonSetValue.TabIndex = 0;
            this.buttonSetValue.Text = "уст.";
            this.buttonSetValue.UseVisualStyleBackColor = true;
            this.buttonSetValue.Click += new System.EventHandler(this.buttonSetValue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "установить V";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "установить A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "считать A";
            // 
            // textBoxSupplyGetA
            // 
            this.textBoxSupplyGetA.Location = new System.Drawing.Point(95, 74);
            this.textBoxSupplyGetA.Name = "textBoxSupplyGetA";
            this.textBoxSupplyGetA.ReadOnly = true;
            this.textBoxSupplyGetA.Size = new System.Drawing.Size(71, 20);
            this.textBoxSupplyGetA.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "считать V";
            // 
            // textBoxSupplyGetV
            // 
            this.textBoxSupplyGetV.Location = new System.Drawing.Point(95, 35);
            this.textBoxSupplyGetV.Name = "textBoxSupplyGetV";
            this.textBoxSupplyGetV.ReadOnly = true;
            this.textBoxSupplyGetV.Size = new System.Drawing.Size(71, 20);
            this.textBoxSupplyGetV.TabIndex = 6;
            // 
            // buttonOutput
            // 
            this.buttonOutput.Location = new System.Drawing.Point(95, 99);
            this.buttonOutput.Name = "buttonOutput";
            this.buttonOutput.Size = new System.Drawing.Size(42, 23);
            this.buttonOutput.TabIndex = 5;
            this.buttonOutput.Text = " ⍈ ";
            this.buttonOutput.UseVisualStyleBackColor = true;
            this.buttonOutput.Click += new System.EventHandler(this.buttonOutput_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.buttonRefresh.Location = new System.Drawing.Point(49, 100);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(28, 23);
            this.buttonRefresh.TabIndex = 10;
            this.buttonRefresh.Text = " ⟳";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // indicatorOutput
            // 
            this.indicatorOutput.BackColor = System.Drawing.Color.Red;
            this.indicatorOutput.Enabled = false;
            this.indicatorOutput.Location = new System.Drawing.Point(143, 99);
            this.indicatorOutput.Name = "indicatorOutput";
            this.indicatorOutput.Size = new System.Drawing.Size(23, 23);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 167);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // FineTuning
            // 
            this.FineTuning.AutoSize = true;
            this.FineTuning.Location = new System.Drawing.Point(6, 129);
            this.FineTuning.Name = "FineTuning";
            this.FineTuning.Size = new System.Drawing.Size(54, 17);
            this.FineTuning.TabIndex = 19;
            this.FineTuning.Text = "точно";
            this.FineTuning.UseVisualStyleBackColor = true;
            this.FineTuning.CheckedChanged += new System.EventHandler(this.FineTuning_CheckedChanged);
            // 
            // numericUpDownSetA
            // 
            this.numericUpDownSetA.DecimalPlaces = 2;
            this.numericUpDownSetA.Location = new System.Drawing.Point(6, 74);
            this.numericUpDownSetA.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownSetA.Name = "numericUpDownSetA";
            this.numericUpDownSetA.Size = new System.Drawing.Size(71, 20);
            this.numericUpDownSetA.TabIndex = 17;
            // 
            // numericUpDownSetV
            // 
            this.numericUpDownSetV.DecimalPlaces = 2;
            this.numericUpDownSetV.Location = new System.Drawing.Point(6, 35);
            this.numericUpDownSetV.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownSetV.Name = "numericUpDownSetV";
            this.numericUpDownSetV.Size = new System.Drawing.Size(71, 20);
            this.numericUpDownSetV.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lamel9);
            this.groupBox2.Controls.Add(this.numericUpDown3);
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.buttonStopMesaure);
            this.groupBox2.Controls.Add(this.buttonStartMesaure);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxMeterGetV);
            this.groupBox2.Controls.Add(this.textBoxMeterGetA);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(195, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 167);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // buttonStopMesaure
            // 
            this.buttonStopMesaure.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.buttonStopMesaure.Location = new System.Drawing.Point(48, 99);
            this.buttonStopMesaure.Name = "buttonStopMesaure";
            this.buttonStopMesaure.Size = new System.Drawing.Size(29, 22);
            this.buttonStopMesaure.TabIndex = 16;
            this.buttonStopMesaure.Text = "█";
            this.buttonStopMesaure.UseVisualStyleBackColor = true;
            this.buttonStopMesaure.Click += new System.EventHandler(this.buttonStopMesaure_Click);
            // 
            // buttonStartMesaure
            // 
            this.buttonStartMesaure.Location = new System.Drawing.Point(6, 100);
            this.buttonStartMesaure.Name = "buttonStartMesaure";
            this.buttonStartMesaure.Size = new System.Drawing.Size(36, 22);
            this.buttonStartMesaure.TabIndex = 12;
            this.buttonStartMesaure.Text = "▶";
            this.buttonStartMesaure.UseVisualStyleBackColor = true;
            this.buttonStartMesaure.Click += new System.EventHandler(this.buttonStartMesaure_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "считать A";
            // 
            // textBoxMeterGetV
            // 
            this.textBoxMeterGetV.Location = new System.Drawing.Point(6, 35);
            this.textBoxMeterGetV.Name = "textBoxMeterGetV";
            this.textBoxMeterGetV.ReadOnly = true;
            this.textBoxMeterGetV.Size = new System.Drawing.Size(71, 20);
            this.textBoxMeterGetV.TabIndex = 12;
            // 
            // textBoxMeterGetA
            // 
            this.textBoxMeterGetA.Location = new System.Drawing.Point(6, 75);
            this.textBoxMeterGetA.Name = "textBoxMeterGetA";
            this.textBoxMeterGetA.ReadOnly = true;
            this.textBoxMeterGetA.Size = new System.Drawing.Size(71, 20);
            this.textBoxMeterGetA.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "считать V";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(450, 24);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "min A";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(71, 20);
            this.textBox1.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(83, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(71, 20);
            this.textBox2.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "min V";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(160, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "max A";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(160, 34);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(71, 20);
            this.textBox3.TabIndex = 21;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(160, 74);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(71, 20);
            this.textBox4.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(160, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "max V";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(9, 129);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown1.TabIndex = 20;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(83, 129);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown2.TabIndex = 25;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(160, 129);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown3.TabIndex = 26;
            // 
            // lamel9
            // 
            this.lamel9.AutoSize = true;
            this.lamel9.Location = new System.Drawing.Point(68, 133);
            this.lamel9.Name = "lamel9";
            this.lamel9.Size = new System.Drawing.Size(12, 13);
            this.lamel9.TabIndex = 27;
            this.lamel9.Text = "ч";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(143, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "м";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(219, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "с";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 209);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

