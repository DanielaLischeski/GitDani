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
    public partial class frmEditarGeneros : Form
    {
        public frmEditarGeneros()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.GenerosRow GenerosRow;

        private void FrmEditarGeneros_Load(object sender, EventArgs e)
        {
            textBox1.Text = GenerosRow.Tipo;
            textBox2.Text = GenerosRow.Descricao;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            GenerosRow.Tipo = textBox1.Text;
            GenerosRow.Descricao = textBox2.Text;

            this.Close();
        }
    }
}
