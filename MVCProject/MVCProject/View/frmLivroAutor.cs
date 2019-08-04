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
    public partial class frmLivroAutor : Form
    {
        public frmLivroAutor()
        {
            InitializeComponent();
        }

        public int IdLivro;

        private void FrmLivroAutor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.LivroAutor' table. You can move, or remove it, as needed.
            this.livroAutorTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.LivroAutor);

        }


        private int AutorOriginal;

        private int LivroOriginal;

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var livroAutorSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as MVCProject.SistemaBibliotecaDBDataSet.LivroAutorRow;
            

            switch (e.ColumnIndex)
            {

                case 0:
                    {
                        this.livroAutorTableAdapter.DeleteQuery(livroAutorSelect.Livro, livroAutorSelect.Autor);
                    }
                    break;
                case 1:
                    {
                        frmEditarLivroAutor editLivroAutor = new frmEditarLivroAutor();
                        editLivroAutor.LivroAutorRow = livroAutorSelect;
                        AutorOriginal = editLivroAutor.LivroAutorRow.Autor;
                        LivroOriginal = editLivroAutor.LivroAutorRow.Livro;
                        editLivroAutor.ShowDialog();

                        this.livroAutorTableAdapter.UpdateQuery(
                            editLivroAutor.LivroAutorRow.Autor,
                            editLivroAutor.LivroAutorRow.Livro,
                            AutorOriginal,
                            LivroOriginal);                       

                    }
                    break;
            }
            this.livroAutorTableAdapter.CustomQuery(this.sistemaBibliotecaDBDataSet.LivroAutor);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarLivroAutor formLivroAutor = new frmAdicionarLivroAutor();
            formLivroAutor.IdLivro = IdLivro;
            formLivroAutor.ShowDialog();

            if (!string.IsNullOrEmpty(formLivroAutor.livroautorRow?.Autor.ToString()))
                this.livroAutorTableAdapter.Insert(
                formLivroAutor.livroautorRow.Livro,
                formLivroAutor.livroautorRow.Autor          
                );

            this.livroAutorTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.LivroAutor);
        }
    }
}
