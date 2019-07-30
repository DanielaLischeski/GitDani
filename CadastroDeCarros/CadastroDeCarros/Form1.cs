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
        }
    }
}
