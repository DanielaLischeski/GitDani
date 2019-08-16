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
    public partial class frmLocacoes : Form
    {
        public frmLocacoes()
        {
            InitializeComponent();
        }

        private void FrmLocações_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Locacao' table. You can move, or remove it, as needed.
            this.locacaoTableAdapter.NomesQuery(this.sistemaBibliotecaDBDataSet.Locacao);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var locacaoSelect = ((System.Data.DataRowView)
               this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
               as MVCProject.SistemaBibliotecaDBDataSet.LocacaoRow;

            switch (e.ColumnIndex)
            {

                case 0:
                    {
                        this.locacaoTableAdapter.DeleteQuery(locacaoSelect.Id);
                    }
                    break;
                case 1:
                    {
                        frmEditarLocacoes editLocacao = new frmEditarLocacoes();
                        editLocacao.LocacaoRow = locacaoSelect;
                        editLocacao.ShowDialog();

                        this.locacaoTableAdapter.UpdateQuery(
                            editLocacao.LocacaoRow.Livro,
                            editLocacao.LocacaoRow.Usuario,
                            editLocacao.LocacaoRow.Tipo,
                            editLocacao.LocacaoRow.Devolucao,
                            editLocacao.LocacaoRow.Ativo,
                            editLocacao.LocacaoRow.UsuInc,
                            editLocacao.LocacaoRow.UsuAlt,
                            editLocacao.LocacaoRow.DatInc,
                            editLocacao.LocacaoRow.DatAlt,
                            editLocacao.LocacaoRow.Id);

                    }
                    break;
            }
            //this.locacaoTableAdapter.CustomQuery(this.sistemaBibliotecaDBDataSet.Locacao);
            this.locacaoTableAdapter.NomesQuery(this.sistemaBibliotecaDBDataSet.Locacao);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarLocacoes formLocacoes = new frmAdicionarLocacoes();
            formLocacoes.ShowDialog();

            if (!string.IsNullOrEmpty(formLocacoes.locacoesRow?.Livro.ToString())) //se é uma string nula ou vazia não adiciona, também permite fechar a janela de adicionar sem dar erro
                this.locacaoTableAdapter.Insert(
                formLocacoes.locacoesRow.Livro,
                formLocacoes.locacoesRow.Usuario,
                formLocacoes.locacoesRow.Tipo,
                formLocacoes.locacoesRow.Devolucao,
                formLocacoes.locacoesRow.Ativo,
                formLocacoes.locacoesRow.UsuInc,
                formLocacoes.locacoesRow.UsuAlt,
                DateTime.Now,
                DateTime.Now
                );

            //this.locacaoTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Locacao);
            this.locacaoTableAdapter.NomesQuery(this.sistemaBibliotecaDBDataSet.Locacao);
        }
    }
}
