using DataGridViewExample.Adicionar;
using DataGridViewExample.Edicao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Marcas);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarMarcas formAddMarcas = new frmAdicionarMarcas();
            formAddMarcas.ShowDialog();

            if (!string.IsNullOrEmpty(formAddMarcas.marcasRow?.Nome))
                this.marcasTableAdapter.Insert(
                formAddMarcas.marcasRow.Nome,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
                );
            //Atualiza a tabela
            this.marcasTableAdapter.Fill(this.querysInnerJoinDataSet1.Marcas);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var marcasSelect = ((System.Data.DataRowView)
               this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
               as DataGridViewExample.QuerysInnerJoinDataSet1.MarcasRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.marcasTableAdapter.DeleteQuery(marcasSelect.Id);
                    }
                    break;
                case 1:
                    {
                        frmEdicaoMarcas editMarca = new frmEdicaoMarcas();
                        editMarca.MarcasRow = marcasSelect;
                        editMarca.ShowDialog();                                             
                        
                        this.marcasTableAdapter.Update(editMarca.MarcasRow);
                    }
                    break;
            }


            this.marcasTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Marcas);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            LixeiraMarcas lixo = new LixeiraMarcas();
            lixo.ShowDialog();
            this.marcasTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Marcas); //permite atualizar a tabela dinamicamente
        }
    }
}
