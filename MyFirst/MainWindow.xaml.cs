using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace MyFirst
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            AddContent(one);
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            AddContent(two);
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            AddContent(three);
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            AddContent(plus);
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            AddContent(four);
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            AddContent(five);
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            AddContent(six);
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            AddContent(minus);
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            AddContent(seven);
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            AddContent(eigth);
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            AddContent(nine);
        }

        private void Multyply_Click(object sender, RoutedEventArgs e)
        {
            AddContent(multyply);
        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            IsEqual(equal);
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            AddContent(zero);
        }

        private void Dot_Click(object sender, RoutedEventArgs e)
        {
            AddContent(dot);
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            AddContent(divide);
        }

        private void AddContent(Button btn)
        {
            tb.Text += btn.Content;
        }

        private void IsEqual(Button btn)
        {
            string str = tb.Text;
            char[] symbols = new char[] { '+', '-', 'x', '/', '%', '^', '?'};
            int ind = -1;
            char symbol = ' ';

            for (int i = 0; i < symbols.Length; i++)
            {
                symbol = symbols[i];
                ind = str.IndexOf(symbol);

                if (ind != -1)
                {
                    break;
                }
            }

            double num1 = Convert.ToDouble(str.Substring(0, ind));
            double num2 = Convert.ToDouble(str.Substring(ind + 1));
            double ans = -1;

            switch (symbol)
            {
                case ('+'):
                    ans = num1 + num2;
                    break;
                case ('-'):
                    ans = num1 - num2;
                    break;
                case ('x'):
                    ans = num1 * num2;
                    break;
                case ('/'):
                    ans = num1 / num2;
                    break;
                case ('%'):
                    ans = num1 * num2 / 100;
                    break;
                case ('^'):
                    ans = Math.Pow(num1, num2);
                    break;
                case('?'):
                    ans = Math.Sqrt(num2);
                    break;
            }

            tb.Text = Convert.ToString(ans);
        }

        private void DeleteAll(Button btn)
        {
            string str = tb.Text;
            str = null;
            tb.Text = str;
        }

        private void DeleteAll_Click(object sender, RoutedEventArgs e)
        {
            DeleteAll(deleteAll);
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            string str = tb.Text;
            str = DeleteLast(str);
            tb.Text = str;

        }

        public static string DeleteLast(string str)
        {
            int len = str.Length;
            try
            {
                string result = str.Substring(0, len - 1);
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Persent_Click(object sender, RoutedEventArgs e)
        {
            AddContent(persent);
        }

        private void Power_Click(object sender, RoutedEventArgs e)
        {
            AddContent(power);
        }

        private void Root_Click(object sender, RoutedEventArgs e)
        {
            AddContent(root);
        }
    }   
}
