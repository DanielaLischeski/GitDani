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
    public partial class frmEditarLocacoes : Form
    {
        public frmEditarLocacoes()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.LocacaoRow LocacaoRow;

        private void FrmEditarLocacoes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);

            comboBox1.SelectedValue = LocacaoRow.Livro;
            comboBox2.SelectedValue = LocacaoRow.Usuario;
            numericUpDown1.Value = LocacaoRow.Tipo;
            dateTimePicker1.Value = LocacaoRow.Devolucao;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LocacaoRow.Livro = (int)comboBox1.SelectedValue;
            LocacaoRow.Usuario = (int)comboBox2.SelectedValue;
            LocacaoRow.Tipo = (int)numericUpDown1.Value;
            LocacaoRow.Devolucao = dateTimePicker1.Value;

            this.Close();
        }
    }
}
