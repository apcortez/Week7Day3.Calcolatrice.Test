using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Wee7Day3.Calcolatrice.Core;

namespace Week7Day3.Calcolatrice.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double valueA;
        private double valueB;
        private string operation;
        Calculator calculator = new Calculator();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonC_Click(object sender, RoutedEventArgs e)
        {
            textValue.Clear();

        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            textValue.Text += button7.Content.ToString();
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            textValue.Text += button8.Content.ToString();
        }
       
        private void button9_Click(object sender, RoutedEventArgs e)
        {
            textValue.Text += button9.Content.ToString();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            textValue.Text += button4.Content.ToString();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            textValue.Text += button5.Content.ToString();
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            textValue.Text += button6.Content.ToString();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            textValue.Text += button1.Content.ToString();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            textValue.Text += button2.Content.ToString();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            textValue.Text += button3.Content.ToString();
        }

        private void buttonpunto_Click(object sender, RoutedEventArgs e)
        {
            textValue.Text += buttonpunto.Content.ToString();
        }

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            textValue.Text += button0.Content.ToString();
        }

        private void buttonpiu_Click(object sender, RoutedEventArgs e)
        {
            SetOperation(textValue.Text, "somma");
        }

        private void SetOperation(string contentValue, string operationToDo)
        {
            valueA = double.Parse(contentValue);
            operation = operationToDo;
            textValue.Clear();
        }

        private void buttonmeno_Click(object sender, RoutedEventArgs e)
        {
            SetOperation(textValue.Text, "sottrai");
        }

        private void buttonmoltiplica_Click(object sender, RoutedEventArgs e)
        {
            SetOperation(textValue.Text, "moltiplica");
        }

        private void buttondiviso_Click(object sender, RoutedEventArgs e)
        {
            SetOperation(textValue.Text, "dividi");
        }

        private void buttonuguale_Click(object sender, RoutedEventArgs e)
        {
            valueB = (string.IsNullOrEmpty(textValue.Text)) ? 0 : double.Parse(textValue.Text);

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
                    var risultato = calculator.Dividi(valueA, valueB).ToString();
                    textValue.Text = (risultato == null) ? "Error" : risultato.ToString();
                    break;
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
