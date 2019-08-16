using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View.Editar
{
    public partial class frmEditarLivros : Form
    {
        public frmEditarLivros()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.LivrosRow LivrosRow;

        private void FrmEditarLivros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet1.Editoras' table. You can move, or remove it, as needed.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet1.Editoras);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);

            numericUpDown1.Value = LivrosRow.Registro;
            textBox1.Text = LivrosRow.Titulo;
            textBox2.Text = LivrosRow.Isbn;
            comboBox1.SelectedValue = LivrosRow.Genero;
            comboBox2.SelectedValue = LivrosRow.Editora;
            textBox4.Text = LivrosRow.Sinopse;
            textBox5.Text = LivrosRow.Observacoes;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LivrosRow.Registro = (int)numericUpDown1.Value;
            LivrosRow.Titulo = textBox1.Text;
            LivrosRow.Isbn = textBox2.Text;
            LivrosRow.Genero = (int)comboBox1.SelectedValue;
            LivrosRow.Editora = (int)comboBox2.SelectedValue;
            LivrosRow.Sinopse = textBox4.Text;
            LivrosRow.Observacoes = textBox5.Text;

            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            frmLivroAutor formLivroAutor = new frmLivroAutor();
            formLivroAutor.IdLivro = LivrosRow.Id;//passa pro LivroAutor o livro atual
            formLivroAutor.ShowDialog();
        }
    }
}
