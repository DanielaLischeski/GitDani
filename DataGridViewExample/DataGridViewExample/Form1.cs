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
            frmAdicionar formAdd = new frmAdicionar();
            formAdd.ShowDialog();
            //Insert na tabela do banco de carros o novo registro
            this.carrosTableAdapter.Insert(
                formAdd.carrosRow.Modelo,
                formAdd.carrosRow.Ano,
                formAdd.carrosRow.Marca,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
                );
            //Atualiza a tabela
            this.carrosTableAdapter.Fill(this.querysInnerJoinDataSet1.Carros);
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

            //usamos o switch porque poderia ter outras opções, neste caso poderia até ser um if 
            switch(e.ColumnIndex) //para escolher quais colunas vão deletar informações
            {
                //Coluna deletar
                case 0: {
                        this.carrosTableAdapter.DeleteQuery(carSelect.Id);                        
                    } break;
                case 1: {
                        frmEdicaoCarros editCarro = new frmEdicaoCarros();
                        editCarro.CarrosRow = carSelect;
                        editCarro.ShowDialog();

                        //this.carrosTableAdapter.Update(editCarrro.CarrosRow); 
                        //é o mesmo que:
                        //só que daí não precisaria criar uma querry para Update
                        //e atualizaria todos os campos, e nós só queremos atualizar: modelo, ano e marca
                        //portato, a forma mais correta é:
                        this.carrosTableAdapter.UpdateQuery(
                            editCarro.CarrosRow.Modelo,
                            editCarro.CarrosRow.Ano.ToString(),
                            editCarro.CarrosRow.Marca,
                            editCarro.CarrosRow.UsuAlt,
                            DateTime.Now,
                            editCarro.CarrosRow.Id);
                                                
                    } break;
            }

            //MessageBox.Show(carSelect.Modelo); //para ver se está dando certo
            // MessageBox.Show(carSelect.Ano.ToString()); //para ver se está dando certo

            this.carrosTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Carros); //para mostrar a lista atualizada
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Lixeira lixo = new Lixeira();
            lixo.ShowDialog();

        }
    }
}
    

