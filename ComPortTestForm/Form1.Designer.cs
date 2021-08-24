
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
            this.SuspendLayout();
            // 
            // buttonSetValue
            // 
            this.buttonSetValue.Location = new System.Drawing.Point(12, 91);
            this.buttonSetValue.Name = "buttonSetValue";
            this.buttonSetValue.Size = new System.Drawing.Size(51, 23);
            this.buttonSetValue.TabIndex = 0;
            this.buttonSetValue.Text = "установка";
            this.buttonSetValue.UseVisualStyleBackColor = true;
            this.buttonSetValue.Click += new System.EventHandler(this.buttonSetValue_Click);
            // 
            // textBoxSetV
            // 
            this.textBoxSetV.Location = new System.Drawing.Point(12, 26);
            this.textBoxSetV.Name = "textBoxSetV";
            this.textBoxSetV.Size = new System.Drawing.Size(100, 20);
            this.textBoxSetV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "установить V";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "установить A";
            // 
            // textBoxSetA
            // 
            this.textBoxSetA.Location = new System.Drawing.Point(12, 65);
            this.textBoxSetA.Name = "textBoxSetA";
            this.textBoxSetA.Size = new System.Drawing.Size(100, 20);
            this.textBoxSetA.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "считать A";
            // 
            // textBoxGetA
            // 
            this.textBoxGetA.Location = new System.Drawing.Point(118, 65);
            this.textBoxGetA.Name = "textBoxGetA";
            this.textBoxGetA.ReadOnly = true;
            this.textBoxGetA.Size = new System.Drawing.Size(100, 20);
            this.textBoxGetA.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "считать V";
            // 
            // textBoxGetV
            // 
            this.textBoxGetV.Location = new System.Drawing.Point(118, 26);
            this.textBoxGetV.Name = "textBoxGetV";
            this.textBoxGetV.ReadOnly = true;
            this.textBoxGetV.Size = new System.Drawing.Size(100, 20);
            this.textBoxGetV.TabIndex = 6;
            // 
            // buttonOutput
            // 
            this.buttonOutput.Location = new System.Drawing.Point(165, 90);
            this.buttonOutput.Name = "buttonOutput";
            this.buttonOutput.Size = new System.Drawing.Size(53, 23);
            this.buttonOutput.TabIndex = 5;
            this.buttonOutput.Text = "выход";
            this.buttonOutput.UseVisualStyleBackColor = true;
            this.buttonOutput.Click += new System.EventHandler(this.buttonOutput_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(92, 6);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(20, 20);
            this.buttonRefresh.TabIndex = 10;
            this.buttonRefresh.Text = "обновление";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(208, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "установка";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 126);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxGetA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxGetV);
            this.Controls.Add(this.buttonOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSetA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSetV);
            this.Controls.Add(this.buttonSetValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

