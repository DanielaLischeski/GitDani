﻿using DataGridViewExample.Adicionar;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Vendas);

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
                        this.vendasTableAdapter.DeleteQuery(vendasSelect.Id);
                    }
                    break;
                case 1:
                    {
                        frmEdicaoVendas editVenda = new frmEdicaoVendas();
                        editVenda.VendasRow = vendasSelect;
                        editVenda.ShowDialog();

                        this.vendasTableAdapter.Update(editVenda.VendasRow);

                    }
                    break;
            }

            this.vendasTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Vendas);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            LixeiraVendas lixo = new LixeiraVendas();
            lixo.ShowDialog();
            this.vendasTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Vendas); //permite atualizar a tabela dinamicamente
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarVendas formAddVendas = new frmAdicionarVendas();
            formAddVendas.ShowDialog();

            if (formAddVendas.vendasRow?.Carro > 0 && formAddVendas.vendasRow?.Valor > 0) //consigo comparar > 0, pois assinei as variáveis com 0 na classe Venda
                this.vendasTableAdapter.Insert(
            formAddVendas.vendasRow.Carro,
            formAddVendas.vendasRow.Quantidade,
            formAddVendas.vendasRow.Valor,
            true, //é o mesmo que: ormAddVendas.vendasRow.Ativo,
            1,    
            1,
            DateTime.Now, //é o mesmo que: ormAddVendas.vendasRow.DatInc,
            DateTime.Now  //é o mesmo que: ormAddVendas.vendasRow.DatAlt,
            );
            //Atualiza a tabela
            this.vendasTableAdapter.Fill(this.querysInnerJoinDataSet1.Vendas);
        }
    }
}
