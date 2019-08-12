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
using System.Windows.Shapes;
using WPFAppEntity.Data;

namespace WPFAppEntity.Views
{
    /// <summary>
    /// Interaction logic for frmEditUser.xaml
    /// </summary>
    public partial class frmEditUser : Window
    {
        public frmEditUser()
        {
            InitializeComponent();
        }

        public Usuario user;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            user.Nome = tbxName.Text;
            user.Login = tbxLogin.Text;
            user.Senha = tbxLogin.Text;

            this.DialogResult = true;
        }
    }
}