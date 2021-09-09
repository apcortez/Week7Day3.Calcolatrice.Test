using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wee7Day3.Calcolatrice.Core;

namespace Week7Day3.Calcolatrice.WinForms
{

    public partial class CalculatorForm : Form
    {
        private double valueA;
        private double valueB;
        private string operation;
        private Calculator calculator = new Calculator();
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textValue.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textValue.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textValue.Text += button9.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textValue.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textValue.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textValue.Text += button6.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textValue.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textValue.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textValue.Text += button3.Text;
        }

        private void buttonpunto_Click(object sender, EventArgs e)
        {
            textValue.Text += buttonpunto.Text;
        }

        private void button00_Click(object sender, EventArgs e)
        {
            textValue.Text += button00.Text;
        }
        private void buttonc_Click(object sender, EventArgs e)
        {
            //textValue.Text = "";
            textValue.Clear();
        }

        public void SetOperation(string contentValue, string operationToDo)
        {
            valueA = double.Parse(contentValue);
            operation = operationToDo;
            textValue.Clear();
        }

        private void buttonpiu_Click(object sender, EventArgs e)
        {
            SetOperation(textValue.Text, buttonpiu.Tag.ToString());
        }

        private void buttonmeno_Click(object sender, EventArgs e)
        {
            SetOperation(textValue.Text, buttonmeno.Tag.ToString());
        }

        private void buttonmoltiplica_Click(object sender, EventArgs e)
        {
            SetOperation(textValue.Text, buttonmoltiplica.Tag.ToString());
        }

        private void buttondividi_Click(object sender, EventArgs e)
        {
            SetOperation(textValue.Text, buttondividi.Tag.ToString());
        }


        private void buttonuguale_Click(object sender, EventArgs e)
        {
            valueB=(string.IsNullOrEmpty(textValue.Text)) ? 0 : double.Parse(textValue.Text);

            switch (operation)
            {
                case "somma":
                    textValue.Text = calculator.Somma(valueA, valueB).ToString();
                    break;
                case "sottrai":
                    textValue.Text = calculator.Sottrai(valueA, valueB).ToString();
                    break;
                case "moltiplica":
                    textValue.Text = calculator.Moltiplica(valueA, valueB).ToString();
                    break;
                case "dividi":
                    var risultato =calculator.Dividi(valueA, valueB).ToString();
                    textValue.Text = (risultato == null) ? "Error" : risultato.ToString();
                    break;
            }
        }
    }
}
