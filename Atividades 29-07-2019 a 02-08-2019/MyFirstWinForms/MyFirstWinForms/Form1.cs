using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Vriável para contar o click do botão
        int countPress = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Click event: {countPress}");
            countPress++;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fechar");

            this.Close();
        }
    }
}
