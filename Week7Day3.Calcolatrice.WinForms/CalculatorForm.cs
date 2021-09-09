using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week7Day3.Calcolatrice.WinForms
{
    public partial class CalculatorForm : Form
    {
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

        private void button0_Click(object sender, EventArgs e)
        {
            textValue.Text += button0.Text;
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
    }
}
