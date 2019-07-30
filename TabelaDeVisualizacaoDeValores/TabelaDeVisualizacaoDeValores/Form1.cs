using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TabelaDeVisualizacaoDeValores.Model;

namespace TabelaDeVisualizacaoDeValores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<Contrac> listContracs = new List<Contrac>();

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            listContracs.Add(new Contrac()
            {
                Id = listContracs.Count,
                Value = new Random().Next(100),
                DatInc = DateTime.Now
            });
                      
            var newList = new List<Contrac>();//é criada uma nova lista para não alterar a lista original

            foreach (Contrac item in listContracs)
                newList.Add(new Contrac()
                {
                    Id = item.Id,
                    Value = item.Value,
                    DatInc = item.DatInc
                }); 
           

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = newList;
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var collumId = dataGridView1.Rows[e.RowIndex].Cells[0];
                var collValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                switch (collValue.ColumnIndex)
                {
                    case 0: {//Caso que representa minha coluna ID
                            MessageBox.Show("Não é possível ajustar esta colina.");
                        } break;
                    case 1: {
                            if (MessageBox.Show("Deseja realmente ajustar este valor?"
                                , "Edição"
                                , MessageBoxButtons.YesNo
                                , MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                listContracs.FirstOrDefault(x =>
                                x.Id == (int)collumId.Value).Value = (int)collValue.Value;
                            }
                        } break;
                    case 2: {
                            if (MessageBox.Show("Deseja realmente ajustar este valor?"
                             , "Edição"
                             , MessageBoxButtons.YesNo
                             , MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                var dataInformada = DateTime.Parse(collValue.Value.ToString());

                                if (dataInformada <= DateTime.Now)
                                    listContracs.FirstOrDefault(x =>
                                    x.Id == (int)collumId.Value).DatInc = DateTime.Parse(collValue.Value.ToString());
                                else
                                    MessageBox.Show("Não foi possível alterar o registro de data.");
                            }
                        } break;
                }
            }
        }
    }
}
