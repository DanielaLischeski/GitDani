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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Carros);
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Carros' table. You can move, or remove it, as needed.


        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 frmMarcas = new Form2();
            frmMarcas.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form3 frmUsuarios = new Form3();
            frmUsuarios.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form5 frmVendas = new Form5();
            frmVendas.ShowDialog();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //((System.Windows.Forms.DataGridViewRow)
            //(((System.Windows.Forms.DataGridView)sender).Rows).Items[0]))
            //.DataBoundItem
            var carSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridViewExample.QuerysInnerJoinDataSet1.CarrosRow;

            //MessageBox.Show(carSelect.Modelo); //para ver se está dando certo
            // MessageBox.Show(carSelect.Ano.ToString()); //para ver se está dando certo

            this.carrosTableAdapter.DeleteQuery(carSelect.Id);
            this.carrosTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Carros); //para mostrar a lista atualizada
        }
    }
}
    

