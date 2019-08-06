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

        //quem chamar o frmLivroAutor deverá informar o Id do livro atual
        public int IdLivro;

        private void FrmLivroAutor_Load(object sender, EventArgs e)
        {
            //TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.LivroAutor' table. You can move, or remove it, as needed.
            this.livroAutorTableAdapter.NomesQuery(this.sistemaBibliotecaDBDataSet.LivroAutor);

        }

        //são variáveis de controle para atualização, para saber qual registro será atualizado
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
                    {   //a chave(PK) pra deletar é composta por dois campos: Livro e Autor
                        this.livroAutorTableAdapter.DeleteQuery(livroAutorSelect.Livro, livroAutorSelect.Autor);
                    }
                    break;
                case 1:
                    {
                        frmEditarLivroAutor editLivroAutor = new frmEditarLivroAutor();
                        editLivroAutor.LivroAutorRow = livroAutorSelect;
                        AutorOriginal = editLivroAutor.LivroAutorRow.Autor;//salva o autor e o livro antes de editar
                        LivroOriginal = editLivroAutor.LivroAutorRow.Livro;
                        editLivroAutor.ShowDialog();

                        this.livroAutorTableAdapter.UpdateQuery(
                            editLivroAutor.LivroAutorRow.Autor,
                            editLivroAutor.LivroAutorRow.Livro,
                            AutorOriginal,//são os valores originais para localizar o vínculo a ser alterado
                            LivroOriginal);                       

                    }
                    break;
            }
            //this.livroAutorTableAdapter.CustomQuery(this.sistemaBibliotecaDBDataSet.LivroAutor);
            this.livroAutorTableAdapter.NomesQuery(this.sistemaBibliotecaDBDataSet.LivroAutor);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarLivroAutor formLivroAutor = new frmAdicionarLivroAutor();
            formLivroAutor.IdLivro = IdLivro;//passa pro frmAdicionarLivroAutor o código do livro atual
            formLivroAutor.ShowDialog();

            if (!string.IsNullOrEmpty(formLivroAutor.livroautorRow?.Autor.ToString()))
                this.livroAutorTableAdapter.Insert(
                formLivroAutor.livroautorRow.Livro,
                formLivroAutor.livroautorRow.Autor          
                );

            //this.livroAutorTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.LivroAutor);
            this.livroAutorTableAdapter.NomesQuery(this.sistemaBibliotecaDBDataSet.LivroAutor);
        }
    }
}
