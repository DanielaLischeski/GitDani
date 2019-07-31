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
    public partial class LixeiraVendas : Form
    {
        public LixeiraVendas()
        {
            InitializeComponent();
        }

        private void LixeiraVendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.SelectInativos(this.querysInnerJoinDataSet1.Vendas);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var vendasSelect = ((System.Data.DataRowView)
               this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
               as DataGridViewExample.QuerysInnerJoinDataSet1.VendasRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.vendasTableAdapter.RestaurarCommand(vendasSelect.Id);
                    }
                    break;
            }

            this.vendasTableAdapter.SelectInativos(this.querysInnerJoinDataSet1.Vendas);
        }
    }
}
