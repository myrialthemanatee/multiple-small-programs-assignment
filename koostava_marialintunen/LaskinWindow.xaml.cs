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
using System.Windows.Shapes;

namespace koostava_marialintunen
{
    /// <summary>
    /// Interaction logic for LaskinWindow.xaml
    /// </summary>
    public partial class LaskinWindow : Window
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        int result = 0;

        public LaskinWindow()
        {
            InitializeComponent();
        }


        private void One_click(object sender, RoutedEventArgs e)
        {
            this.calc_screen.Text = "";
            input += 1;
            this.calc_screen.Text += input;
        }

        private void Two_click(object sender, RoutedEventArgs e)
        {
            this.calc_screen.Text = "";
            input += 2;
            this.calc_screen.Text += input;
        }

        private void Three_click(object sender, RoutedEventArgs e)
        {
            this.calc_screen.Text = "";
            input += 3;
            this.calc_screen.Text += input;
        }

        private void Four_click(object sender, RoutedEventArgs e)
        {
            this.calc_screen.Text = "";
            input += 4;
            this.calc_screen.Text += input;
        }

        private void Five_click(object sender, RoutedEventArgs e)
        {
            this.calc_screen.Text = "";
            input += 5;
            this.calc_screen.Text += input;
        }

        private void Six_click(object sender, RoutedEventArgs e)
        {
            this.calc_screen.Text = "";
            input += 6;
            this.calc_screen.Text += input;
        }

        private void Seven_click(object sender, RoutedEventArgs e)
        {
            this.calc_screen.Text = "";
            input += 7;
            this.calc_screen.Text += input;
        }

        private void Eight_click(object sender, RoutedEventArgs e)
        {
            this.calc_screen.Text = "";
            input += 8;
            this.calc_screen.Text += input;
        }

        private void Nine_click(object sender, RoutedEventArgs e)
        {
            this.calc_screen.Text = "";
            input += 9;
            this.calc_screen.Text += input;
        }

        private void Sum_click(object sender, RoutedEventArgs e)
        {
            operand2 = input;
            int num1, num2;
            int.TryParse(operand1, out num1);
            int.TryParse(operand2, out num2);
            result = num1 + num2;
            calc_screen.Text = result.ToString();
        }

        private void Plus_click(object sender, RoutedEventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void Clear_click(object sender, RoutedEventArgs e)
        {
            this.calc_screen.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }
    }
}
