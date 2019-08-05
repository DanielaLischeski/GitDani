using MVCProject.Model;
using MVCProject.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         
        }

        public static int UsuarioLogado;

        private void Button1_Click(object sender, EventArgs e)
        {

            //this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);

            //UsuarioLogado = Id que for adicionado
            //UsuarioLogado = 2; //           
            //UsuarioLogado = (int)this.usuariosTableAdapter.LoginQuery(this.sistemaBibliotecaDBDataSet.Usuarios, textBox1.Text, textBox2.Text);
            //se digitar usuario ou senha inválidos, retorna Id = 0, logo:
           // if ((UsuarioLogado != 0) || ((textBox1.Text == "admin") && (textBox2.Text == "admin"))) {
                //se Id diferente de zero OU usuário e senha admin, permite entrar no sistema
               // frmPrincipal formPrincipal = new frmPrincipal();//
               // formPrincipal.ShowDialog();//
                                           // }  else
                                           // {
                                           //     MessageBox.Show("Usuario ou senha inválidos");
                                           //}

            var result = this.usuariosTableAdapter.LoginQuery(textBox1.Text, textBox2.Text);

            if(result != null)
            {
                Session.user = new Usuario();
                Session.user.Id = (int)result;
                //É o mesmo que:
                //Session.user = new Usuario
                //{
                //Id = (int)result
                //};
                
                frmPrincipal frm = new frmPrincipal();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login ou senha inválidos");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
    }
}
