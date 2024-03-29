﻿using MVCProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View.Adicionar
{
    public partial class frmAdicionarLivroAutor : Form
    {
        public frmAdicionarLivroAutor()
        {
            InitializeComponent();
        }

        public LivroAutor livroautorRow;

        public int IdLivro;

        private void FrmAdicionarLivroAutor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Autores' table. You can move, or remove it, as needed.
            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autores);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            livroautorRow = new LivroAutor
            {
                Autor = (int)comboBox1.SelectedValue,
                Livro = IdLivro
            };
            this.Close();
        }
    }
}
