﻿using System;
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
    /// Interaction logic for usLogin.xaml
    /// </summary>
    public partial class usLogin : UserControl
    {
        public usLogin()
        {
            InitializeComponent();
        }

        public event EventHandler logicCorrect;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Teste(tbxLogin.Text, tbxSenha.Text);
        }

        public void Teste(string login, string senha)
        {
            if (login == "admin" && senha == "admin")
            {
                //Aqui apenas recebo uma informação no evento que logou.
                this.Visibility = Visibility.Hidden;
                logicCorrect(null, new EventArgs());
            }
            else
                //Aqui apenas recebo uma informação no evento que falhou o login.
                MessageBox.Show("Login ou senha inválidos!");
        }
    }
}
