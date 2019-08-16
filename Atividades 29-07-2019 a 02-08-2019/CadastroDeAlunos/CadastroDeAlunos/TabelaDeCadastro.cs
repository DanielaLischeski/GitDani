using CadastroDeAlunos.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDeAlunos
{
    public partial class TabelaDeCadastro : Form
    {
        public TabelaDeCadastro()
        {
            InitializeComponent();
        }

        public Aluno novoAluno = new Aluno();

        private void Salvar_Click(object sender, EventArgs e)
        {
            novoAluno.Nome = txbNome.Text;
            novoAluno.Idade = (int)nrIdade.Value;

            this.Close();
        }
    }
}
