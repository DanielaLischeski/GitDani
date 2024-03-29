﻿using System;
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
    public partial class LixeiraUsuarios : Form
    {
        public LixeiraUsuarios()
        {
            InitializeComponent();
        }

        private void LixeiraUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.SelectInativos(this.querysInnerJoinDataSet1.Usuarios);

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
                        this.usuariosTableAdapter.Restaurar(usuariosSelect.Id);
                    }
                    break;
            }
            this.usuariosTableAdapter.SelectInativos(this.querysInnerJoinDataSet1.Usuarios);

        }
    }
}
