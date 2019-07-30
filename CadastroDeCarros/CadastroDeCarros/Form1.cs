using CadastroDeCarros.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDeCarros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<Carro> carros = new List<Carro>();

        private void Button1_Click(object sender, EventArgs e)
        {
            TelaDeCadastro formularioCadastro = new TelaDeCadastro();
            formularioCadastro.ShowDialog();
            carros.Add(formularioCadastro.novoCarro);

            var newList = new List<Carro>();//é criada uma nova lista para não alterar a lista original

            foreach (Carro item in carros)
                newList.Add(new Carro()
                {
                    Modelo = item.Modelo,
                    Ano = item.Ano,
                    Placa = item.Placa
                });


            dataGridView1.DataSource = null;
            dataGridView1.DataSource = newList;
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var collEdit = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                var datCollSelect = collEdit.OwningColumn.DataPropertyName;

                switch(datCollSelect)
                {
                    case "Placa": {
                        if()
                            {
                            }
                        } break;
                }
            }

            dataGridView1.Refresh();
            dataGridView1.RefreshEdit();
        }
    }
}
