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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Usuarios);

        }

        private void Button2_Click(object sender, EventArgs e)
        {


        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var usuariosSelect = ((System.Data.DataRowView)
               this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
               as DataGridViewExample.QuerysInnerJoinDataSet1.UsuariosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.usuariosTableAdapter.DeleteQuery(usuariosSelect.Id);
                    }
                    break;
                case 1:
                    {
                        frmEdicaoUsuarios editUsuario = new frmEdicaoUsuarios();
                        editUsuario.UsuariosRow = usuariosSelect;
                        editUsuario.ShowDialog();

                        this.usuariosTableAdapter.Update(editUsuario.UsuariosRow);

                    }
                    break;
            }
            this.usuariosTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Usuarios);
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            LixeiraUsuarios lixo = new LixeiraUsuarios();
            lixo.ShowDialog();
            this.usuariosTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Usuarios); //permite atualizar a tabela dinamicamente
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarUsuarios formAddUsuarios = new frmAdicionarUsuarios();
            formAddUsuarios.ShowDialog();

            if (!string.IsNullOrEmpty(formAddUsuarios.usuariosRow?.NomeUsuario))
                this.usuariosTableAdapter.Insert(
                formAddUsuarios.usuariosRow.NomeUsuario,                
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
                );
            //Atualiza a tabela
            this.usuariosTableAdapter.Fill(this.querysInnerJoinDataSet1.Usuarios);

        }
    }
}
