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

namespace WpfApp4
{
    public partial class MainWindow : Window
    {
        private double result;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            string text1 = textbox1.Text.Trim();
            string text2 = textbox2.Text.Trim();

            double num1 = 0;
            double num2 = 0;

            if (!string.IsNullOrEmpty(text1) && !string.IsNullOrEmpty(text2))
            {
                try
                {
                    num1 = Convert.ToInt32(text1);
                    num2 = Convert.ToInt32(text2);
                }
                catch (Exception exc) { }

                Calculate1(num1, num2);
            }
        }

        private void Calculate1(double num1, double num2)
        {
            if (combobox.SelectedIndex == 0)
            {
                result = num1 + num2;
            }

            if (combobox.SelectedIndex == 1)
            {
                result = num1 - num2;
            }

            if (combobox.SelectedIndex == 2)
            {
                result = num1 * num2;
            }

            if (combobox.SelectedIndex == 3)
            {
                result = num1 / num2;
            }

            if (combobox.SelectedIndex == 4)
            {
                result = (num1 * num2) /100;
            }

            if (combobox.SelectedIndex == 5)
            {
                result = Math.Sin(num1);
            }

            if (combobox.SelectedIndex == 6)
            {
                result = Math.Cos(num1);
            }

            if (combobox.SelectedIndex == 7)
            {
                result = Math.Tan(num1);
            }

            if (combobox.SelectedIndex == 8)
            {
                result = Math.Asin(num1);
            }

            if (combobox.SelectedIndex == 9)
            {
                result = Math.Acos(num1);
            }

            if (combobox.SelectedIndex == 10)
            {
                result = Math.Atan(num1);
            }

            if (combobox.SelectedIndex == 11)
            {
                result = Math.Sqrt(num1);
            }

            if (combobox.SelectedIndex == 12)
            {
                result = num1 * num1;
            }

            if (combobox.SelectedIndex == 13)
            {
                result = num1 ^ num2;
            }

            UpdateView1();
        }

        private void UpdateView1()
        {
            textblock1.Text = "= " + result.ToString();
        }
    }
}
