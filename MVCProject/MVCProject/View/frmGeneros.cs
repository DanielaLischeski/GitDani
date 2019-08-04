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
    public partial class frmGeneros : Form
    {
        public frmGeneros()
        {
            InitializeComponent();
        }

        private void FrmGeneros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var generoSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as MVCProject.SistemaBibliotecaDBDataSet.GenerosRow;

            switch (e.ColumnIndex)
            {

                case 0:
                    {
                        this.generosTableAdapter.DeleteQuery(generoSelect.Id);
                    }
                    break;
                case 1:
                    {
                        frmEditarGeneros editGenero = new frmEditarGeneros();
                        editGenero.GenerosRow = generoSelect;
                        editGenero.ShowDialog();

                        this.generosTableAdapter.UpdateQuery(
                            editGenero.GenerosRow.Tipo,
                            editGenero.GenerosRow.Descricao,
                            editGenero.GenerosRow.Id);

                    }
                    break;
            }
            this.generosTableAdapter.CustomQuery(this.sistemaBibliotecaDBDataSet.Generos);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarGeneros formGeneros = new frmAdicionarGeneros();
            formGeneros.ShowDialog();

            if (!string.IsNullOrEmpty(formGeneros.generosRow?.Tipo)) 
                this.generosTableAdapter.Insert(
                formGeneros.generosRow.Tipo,
                formGeneros.generosRow.Descricao
                );

            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);
        }
    }
}
