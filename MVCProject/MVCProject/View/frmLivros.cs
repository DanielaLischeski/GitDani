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
    public partial class frmLivros : Form
    {
        public frmLivros()
        {
            InitializeComponent();
        }

        private void FrmLivros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.NomesQuery(this.sistemaBibliotecaDBDataSet.Livros);          


        }


        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var livroSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as MVCProject.SistemaBibliotecaDBDataSet.LivrosRow;

            switch (e.ColumnIndex)
            {

                case 0:
                    {
                        this.livrosTableAdapter.DeleteQuery(livroSelect.Id);
                    }
                    break;
                case 1:
                    {
                        frmEditarLivros editLivro = new frmEditarLivros();
                        editLivro.LivrosRow = livroSelect;
                        editLivro.ShowDialog();

                        this.livrosTableAdapter.UpdateQuery(
                            editLivro.LivrosRow.Registro,
                            editLivro.LivrosRow.Titulo,
                            editLivro.LivrosRow.Isbn,
                            editLivro.LivrosRow.Genero,
                            editLivro.LivrosRow.Editora,
                            editLivro.LivrosRow.Sinopse,
                            editLivro.LivrosRow.Observacoes,
                            editLivro.LivrosRow.Ativo,
                            editLivro.LivrosRow.UsuInc,
                            editLivro.LivrosRow.UsuAlt,
                            editLivro.LivrosRow.DatInc,
                            editLivro.LivrosRow.DatAlt,
                            editLivro.LivrosRow.Id);

                    }
                    break;
            }
            //this.livrosTableAdapter.CustomQuery(this.sistemaBibliotecaDBDataSet.Livros);
            this.livrosTableAdapter.NomesQuery(this.sistemaBibliotecaDBDataSet.Livros);

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarLivros formLivros = new frmAdicionarLivros();
            formLivros.ShowDialog();

            if (!string.IsNullOrEmpty(formLivros.livrosRow?.Titulo))
                this.livrosTableAdapter.Insert(
                formLivros.livrosRow.Registro,
                formLivros.livrosRow.Titulo,
                formLivros.livrosRow.Isbn,
                formLivros.livrosRow.Genero,
                formLivros.livrosRow.Editora,
                formLivros.livrosRow.Sinopse,
                formLivros.livrosRow.Observacoes,
                formLivros.livrosRow.Ativo,
                formLivros.livrosRow.UsuInc,
                formLivros.livrosRow.UsuAlt,
                DateTime.Now,
                DateTime.Now
                );

            //this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);
            this.livrosTableAdapter.NomesQuery(this.sistemaBibliotecaDBDataSet.Livros);

        }
    }
}
