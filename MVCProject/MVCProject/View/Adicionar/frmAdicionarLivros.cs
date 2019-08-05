using MVCProject.Model;
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
    public partial class frmAdicionarLivros : Form
    {
        public frmAdicionarLivros()
        {
            InitializeComponent();
        }

        public Livro livrosRow;


        private void FrmAdicionarLivros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Editoras' table. You can move, or remove it, as needed.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            livrosRow = new Livro
            {
                Registro = (int)numericUpDown1.Value,
                Titulo = textBox2.Text,
                Isbn = textBox1.Text,
                Genero = (int)comboBox1.SelectedValue,
                Editora = (int)comboBox2.SelectedValue,
                Sinopse = textBox4.Text,
                Observacoes = textBox5.Text,
                UsuInc = Session.user.Id,
                UsuAlt = Session.user.Id
            };
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
         
        }
    }
}
