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
    public partial class frmAutores : Form
    {
        public frmAutores()
        {
            InitializeComponent();
        }

        private void FrmAutores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Autores' table. You can move, or remove it, as needed.
            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autores);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var autorSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as MVCProject.SistemaBibliotecaDBDataSet.AutoresRow;

            switch (e.ColumnIndex) 
            {
                
                case 0:
                    {
                        frmEditarAutores editAutor = new frmEditarAutores();
                        editAutor.AutoresRow = autorSelect;
                        editAutor.ShowDialog();

                        this.autoresTableAdapter.UpdateQuery(
                            editAutor.AutoresRow.Nome,
                            editAutor.AutoresRow.Descricao,
                            editAutor.AutoresRow.Id);

                    }
                    break;
              
            }
            this.autoresTableAdapter.CustomQuery(this.sistemaBibliotecaDBDataSet.Autores);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarAutores formAutores = new frmAdicionarAutores();
            formAutores.ShowDialog();
           
            if (!string.IsNullOrEmpty(formAutores.autorRow?.Nome)) //se é uma string nula ou vazia não adiciona, também permite fechar a janela de adicionar sem dar erro
                this.autoresTableAdapter.Insert(
                formAutores.autorRow.Nome,
                formAutores.autorRow.Descricao              
                );
           
            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autores);
        }
    }
}
