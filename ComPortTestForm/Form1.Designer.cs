
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
            this.textBoxSetV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSetA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxGetA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxGetV = new System.Windows.Forms.TextBox();
            this.buttonOutput = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSetValue
            // 
            this.buttonSetValue.Location = new System.Drawing.Point(6, 100);
            this.buttonSetValue.Name = "buttonSetValue";
            this.buttonSetValue.Size = new System.Drawing.Size(100, 23);
            this.buttonSetValue.TabIndex = 0;
            this.buttonSetValue.Text = "установка";
            this.buttonSetValue.UseVisualStyleBackColor = true;
            this.buttonSetValue.Click += new System.EventHandler(this.buttonSetValue_Click);
            // 
            // textBoxSetV
            // 
            this.textBoxSetV.Location = new System.Drawing.Point(6, 35);
            this.textBoxSetV.Name = "textBoxSetV";
            this.textBoxSetV.Size = new System.Drawing.Size(100, 20);
            this.textBoxSetV.TabIndex = 1;
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
            // textBoxSetA
            // 
            this.textBoxSetA.Location = new System.Drawing.Point(6, 74);
            this.textBoxSetA.Name = "textBoxSetA";
            this.textBoxSetA.Size = new System.Drawing.Size(100, 20);
            this.textBoxSetA.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "считать A";
            // 
            // textBoxGetA
            // 
            this.textBoxGetA.Location = new System.Drawing.Point(141, 74);
            this.textBoxGetA.Name = "textBoxGetA";
            this.textBoxGetA.ReadOnly = true;
            this.textBoxGetA.Size = new System.Drawing.Size(71, 20);
            this.textBoxGetA.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "считать V";
            // 
            // textBoxGetV
            // 
            this.textBoxGetV.Location = new System.Drawing.Point(141, 35);
            this.textBoxGetV.Name = "textBoxGetV";
            this.textBoxGetV.ReadOnly = true;
            this.textBoxGetV.Size = new System.Drawing.Size(71, 20);
            this.textBoxGetV.TabIndex = 6;
            // 
            // buttonOutput
            // 
            this.buttonOutput.Location = new System.Drawing.Point(141, 99);
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
            this.buttonRefresh.Location = new System.Drawing.Point(6, 129);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(28, 23);
            this.buttonRefresh.TabIndex = 10;
            this.buttonRefresh.Text = " ⟳";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(189, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.buttonRefresh);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.buttonSetValue);
            this.groupBox1.Controls.Add(this.textBoxSetV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxGetA);
            this.groupBox1.Controls.Add(this.textBoxSetA);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxGetV);
            this.groupBox1.Controls.Add(this.buttonOutput);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 206);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(247, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 161);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "установка";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(141, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "выход";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 247);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSetValue;
        private System.Windows.Forms.TextBox textBoxSetV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSetA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxGetA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxGetV;
        private System.Windows.Forms.Button buttonOutput;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
    }
}

