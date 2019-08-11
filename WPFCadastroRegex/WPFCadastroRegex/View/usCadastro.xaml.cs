using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WPFCadastroRegex.View
{
    /// <summary>
    /// Interaction logic for usCadastro.xaml
    /// </summary>
    public partial class usCadastro : UserControl
    {
        public usCadastro()
        {
            InitializeComponent();
        }
               

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var testeTelefone = tbxTelefone.Text;

            //valida números: +554733332066 ou +55 473332066, etc, desde que tenha +
            
            Regex rgFone = new Regex("^\\+(?:[0-9] ?){6,14}[0-9]$");      
            
            if (rgFone.IsMatch(testeTelefone))
            {
                MessageBox.Show("Telefone Valido!");
            }
            else
            {
                MessageBox.Show("Telefone Inválido!");
            }
            

            var testeEmail = tbxEmail.Text;

            Regex rgEmail = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)$");
     
            if (rgEmail.IsMatch(testeEmail))
            {
                MessageBox.Show("Email Valido!");
            }
            else
            {
                MessageBox.Show("Email Inválido!");
            }
        }
    }
}
