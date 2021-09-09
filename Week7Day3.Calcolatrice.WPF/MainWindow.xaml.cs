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
    }
}
