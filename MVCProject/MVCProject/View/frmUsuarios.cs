using MVCProject.View.Adicionar;
using MVCProject.View.Editar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);

        }



        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var usuarioSelect = ((System.Data.DataRowView)
               this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
               as MVCProject.SistemaBibliotecaDBDataSet.UsuariosRow;

            switch (e.ColumnIndex)
            {

                case 0:
                    {
                        this.usuariosTableAdapter.DeleteQuery(usuarioSelect.Id);
                    }
                    break;
                case 1:
                    {
                        frmEditarUsuarios editUsuario = new frmEditarUsuarios();
                        editUsuario.UsuariosRow = usuarioSelect;
                        editUsuario.ShowDialog();

                        this.usuariosTableAdapter.UpdateQuery(
                            editUsuario.UsuariosRow.Nome,
                            editUsuario.UsuariosRow.Login,
                            editUsuario.UsuariosRow.Senha,
                            editUsuario.UsuariosRow.Email,
                            editUsuario.UsuariosRow.Ativo,
                            editUsuario.UsuariosRow.UsuInc,
                            editUsuario.UsuariosRow.UsuAlt,
                            editUsuario.UsuariosRow.DatInc,
                            editUsuario.UsuariosRow.DatAlt,                            
                            editUsuario.UsuariosRow.Id);

                    }
                    break;
            }
            this.usuariosTableAdapter.CustomQuery(this.sistemaBibliotecaDBDataSet.Usuarios);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarUsuarios formUsuarios = new frmAdicionarUsuarios();
            formUsuarios.ShowDialog();

            if (!string.IsNullOrEmpty(formUsuarios.usuariosRow?.Nome)) 
                this.usuariosTableAdapter.Insert(
                formUsuarios.usuariosRow.Nome,
                formUsuarios.usuariosRow.Login,
                formUsuarios.usuariosRow.Senha,
                formUsuarios.usuariosRow.Email,
                formUsuarios.usuariosRow.Ativo,
                formUsuarios.usuariosRow.UsuInc,
                formUsuarios.usuariosRow.UsuAlt,                
                DateTime.Now,
                DateTime.Now
                );

            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);
        }
    }
}
