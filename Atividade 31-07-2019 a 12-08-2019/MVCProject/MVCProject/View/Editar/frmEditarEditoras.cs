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
    public partial class frmEditarEditoras : Form
    {
        public frmEditarEditoras()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.EditorasRow EditorasRow;

        private void FrmEditarEditoras_Load(object sender, EventArgs e)
        {
            textBox1.Text = EditorasRow.Nome;
            textBox2.Text = EditorasRow.Descricao;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            EditorasRow.Nome = textBox1.Text;
            EditorasRow.Descricao = textBox2.Text;
            
            this.Close();
        }
     
    }
}
