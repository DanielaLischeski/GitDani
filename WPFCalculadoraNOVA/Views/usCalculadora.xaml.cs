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

namespace WPFCalculadora.Views
{
    /// <summary>
    /// Interaction logic for usCalculadora.xaml
    /// </summary>
    public partial class usCalculadora : UserControl
    {
        double acumula = 0;
        string operacao = "";

        public usCalculadora()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "0";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            display.Text += "1";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            display.Text += "2";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            display.Text += "3";           
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            display.Text += "4";           
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            display.Text += "5";            
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            display.Text += "6";          
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            display.Text += "7";          
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            display.Text += "8";           
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            display.Text += "9";          
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            //botão C
            display.Text = "";           
            operacao = "";
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            //botão CE
            acumula = 0;
            display.Text = "";
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            //botão apaga o último número digitado
            int x = display.Text.Length - 1;
            if (x >= 0)
            {
                display.Text = display.Text.Substring(0, x);
            }
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            //botao +/-
            double x = double.Parse(display.Text) * (-1);
            display.Text = x.ToString();
        }


        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            //botão vírgula
            display.Text += ",";
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            if (operacao == "*" || operacao == "-" || operacao == "/")
            {
                operacao = "+";
            }
            else
            {
                acumula = double.Parse(display.Text);
                display.Text += "+";                
                operacao = "+";
            }
        }             

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            if (operacao == "*" || operacao == "+" || operacao == "/")
            {
                operacao = "-";
            }
            else
            {
                acumula = double.Parse(display.Text);
                display.Text += "-";                
                operacao = "-";
            }
        }
        

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            if (operacao == "-" || operacao == "+" || operacao == "/")
            {
                operacao = "*";
            }
            else
            {
                acumula = double.Parse(display.Text);
                display.Text += "*";               
                operacao = "*";
            }


        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            if (operacao == "*" || operacao == "+" || operacao == "-")
            {
                
                operacao = "/";
            }
            else
            {
                acumula = double.Parse(display.Text);
                display.Text += "/";           
                operacao = "/";
            }
        }

        /// <summary>
        /// Método que realiza os cálculos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            if (operacao == "+")
            {                
                acumula += double.Parse(display.Text.Split('+')[1].ToString());
                display.Text += "=" + acumula.ToString();
                //acumula += double.Parse(display.Text);
                //display.Text = acumula.ToString();
            }
            else if (operacao == "-")
            {
                acumula -= double.Parse(display.Text.Split('-')[1].ToString());
                display.Text += "=" + acumula.ToString();                
            }
            else if (operacao == "*")
            {
                acumula *= double.Parse(display.Text.Split('*')[1].ToString());
                display.Text += "=" + acumula.ToString();              
            }
            else if (operacao == "/")
            {
                if (double.Parse(display.Text) != 0)
                {
                    acumula /= double.Parse(display.Text.Split('/')[1].ToString());
                    display.Text += "=" + acumula.ToString();                   
                }
                else
                {
                    display.Text = "ERRO: divisão por zero";
                }
            }
        }
    }
}
