﻿using DataGridViewExample.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample.Adicionar
{
    public partial class frmAdicionarUsuarios : Form
    {
        public frmAdicionarUsuarios()
        {
            InitializeComponent();
        }

        public Usuario usuariosRow;

        private void Button1_Click(object sender, EventArgs e)
        {
            usuariosRow = new Usuario
            {
                NomeUsuario = textBox1.Text,             
            };

            this.Close();
        }
    }
}
