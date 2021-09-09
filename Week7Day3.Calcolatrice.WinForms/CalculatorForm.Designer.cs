
namespace Week7Day3.Calcolatrice.WinForms
{
    partial class CalculatorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonc = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonpiu = new System.Windows.Forms.Button();
            this.buttonmeno = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonmoltiplica = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttondividi = new System.Windows.Forms.Button();
            this.buttonuguale = new System.Windows.Forms.Button();
            this.button00 = new System.Windows.Forms.Button();
            this.buttonpunto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textValue
            // 
            this.textValue.Location = new System.Drawing.Point(38, 56);
            this.textValue.Name = "textValue";
            this.textValue.ReadOnly = true;
            this.textValue.Size = new System.Drawing.Size(194, 27);
            this.textValue.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Value";
            // 
            // buttonc
            // 
            this.buttonc.Location = new System.Drawing.Point(258, 54);
            this.buttonc.Name = "buttonc";
            this.buttonc.Size = new System.Drawing.Size(44, 29);
            this.buttonc.TabIndex = 2;
            this.buttonc.Text = "C";
            this.buttonc.UseVisualStyleBackColor = true;
            this.buttonc.Click += new System.EventHandler(this.buttonc_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(39, 109);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(44, 39);
            this.button7.TabIndex = 3;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(114, 109);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(44, 39);
            this.button8.TabIndex = 4;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(188, 109);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(44, 39);
            this.button9.TabIndex = 5;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // buttonpiu
            // 
            this.buttonpiu.Location = new System.Drawing.Point(258, 109);
            this.buttonpiu.Name = "buttonpiu";
            this.buttonpiu.Size = new System.Drawing.Size(44, 39);
            this.buttonpiu.TabIndex = 6;
            this.buttonpiu.Tag = "somma";
            this.buttonpiu.Text = "+";
            this.buttonpiu.UseVisualStyleBackColor = true;
            this.buttonpiu.Click += new System.EventHandler(this.buttonpiu_Click);
            // 
            // buttonmeno
            // 
            this.buttonmeno.Location = new System.Drawing.Point(258, 170);
            this.buttonmeno.Name = "buttonmeno";
            this.buttonmeno.Size = new System.Drawing.Size(44, 39);
            this.buttonmeno.TabIndex = 10;
            this.buttonmeno.Tag = "sottrai";
            this.buttonmeno.Text = "-";
            this.buttonmeno.UseVisualStyleBackColor = true;
            this.buttonmeno.Click += new System.EventHandler(this.buttonmeno_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(188, 170);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(44, 39);
            this.button6.TabIndex = 9;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(114, 170);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(44, 39);
            this.button5.TabIndex = 8;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(39, 170);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(44, 39);
            this.button4.TabIndex = 7;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonmoltiplica
            // 
            this.buttonmoltiplica.Location = new System.Drawing.Point(258, 231);
            this.buttonmoltiplica.Name = "buttonmoltiplica";
            this.buttonmoltiplica.Size = new System.Drawing.Size(44, 39);
            this.buttonmoltiplica.TabIndex = 14;
            this.buttonmoltiplica.Tag = "moltiplica";
            this.buttonmoltiplica.Text = "*";
            this.buttonmoltiplica.UseVisualStyleBackColor = true;
            this.buttonmoltiplica.Click += new System.EventHandler(this.buttonmoltiplica_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(188, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 39);
            this.button3.TabIndex = 13;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(114, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 39);
            this.button2.TabIndex = 12;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttondividi
            // 
            this.buttondividi.Location = new System.Drawing.Point(258, 300);
            this.buttondividi.Name = "buttondividi";
            this.buttondividi.Size = new System.Drawing.Size(44, 39);
            this.buttondividi.TabIndex = 18;
            this.buttondividi.Tag = "dividi";
            this.buttondividi.Text = "/";
            this.buttondividi.UseVisualStyleBackColor = true;
            this.buttondividi.Click += new System.EventHandler(this.buttondividi_Click);
            // 
            // buttonuguale
            // 
            this.buttonuguale.Location = new System.Drawing.Point(188, 300);
            this.buttonuguale.Name = "buttonuguale";
            this.buttonuguale.Size = new System.Drawing.Size(44, 39);
            this.buttonuguale.TabIndex = 17;
            this.buttonuguale.Text = "=";
            this.buttonuguale.UseVisualStyleBackColor = true;
            this.buttonuguale.Click += new System.EventHandler(this.buttonuguale_Click);
            // 
            // button00
            // 
            this.button00.Location = new System.Drawing.Point(114, 300);
            this.button00.Name = "button00";
            this.button00.Size = new System.Drawing.Size(44, 39);
            this.button00.TabIndex = 16;
            this.button00.Text = "0";
            this.button00.UseVisualStyleBackColor = true;
            this.button00.Click += new System.EventHandler(this.button00_Click);
            // 
            // buttonpunto
            // 
            this.buttonpunto.Location = new System.Drawing.Point(39, 300);
            this.buttonpunto.Name = "buttonpunto";
            this.buttonpunto.Size = new System.Drawing.Size(44, 39);
            this.buttonpunto.TabIndex = 15;
            this.buttonpunto.Text = ".";
            this.buttonpunto.UseVisualStyleBackColor = true;
            this.buttonpunto.Click += new System.EventHandler(this.buttonpunto_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 366);
            this.Controls.Add(this.buttondividi);
            this.Controls.Add(this.buttonuguale);
            this.Controls.Add(this.button00);
            this.Controls.Add(this.buttonpunto);
            this.Controls.Add(this.buttonmoltiplica);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonmeno);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonpiu);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textValue);
            this.Name = "CalculatorForm";
            this.Text = "My Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonc;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonpiu;
        private System.Windows.Forms.Button buttonmeno;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonmoltiplica;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttondividi;
        private System.Windows.Forms.Button buttonuguale;
        private System.Windows.Forms.Button button00;
        private System.Windows.Forms.Button buttonpunto;
    }
}

