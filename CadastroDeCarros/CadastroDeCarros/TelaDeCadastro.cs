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
    public partial class TelaDeCadastro : Form
    {
        public TelaDeCadastro()
        {
            InitializeComponent();
        }

        public Carro novoCarro = new Carro();

        private void Button1_Click(object sender, EventArgs e)
        {
            novoCarro.Modelo = txbModelo.Text;
            novoCarro.Ano = (int)nrAno.Value;
            novoCarro.Placa = txbPlaca.Text;

            this.Close();
        }
    }
}
