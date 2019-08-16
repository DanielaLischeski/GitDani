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
    public partial class frmEditarUsuarios : Form
    {
        public frmEditarUsuarios()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.UsuariosRow UsuariosRow;
        private void FrmEditarUsuarios_Load(object sender, EventArgs e)
        {
            textBox1.Text = UsuariosRow.Nome;
            textBox2.Text = UsuariosRow.Login;
            textBox3.Text = UsuariosRow.Senha;
            textBox4.Text = UsuariosRow.Email;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UsuariosRow.Nome = textBox1.Text;
            UsuariosRow.Login = textBox2.Text;
            UsuariosRow.Senha = textBox3.Text;
            UsuariosRow.Email = textBox4.Text;

            this.Close();
        }
    }
}
