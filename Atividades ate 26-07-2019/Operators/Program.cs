using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //var elementoX = new Teste("Daniela","minhasenha"); //o construtor possui 2 informações, usuário e senha, então aqui preciso colocar estas 2 informações
            var elementoX = new Teste(5,5); //através do new Teste ele consegue acessar o construtor

            elementoX.MostrarInformacoes();  //elementoX é uma instância

            elementoX.AlteraInformacoes(5,5);

            elementoX.MostrarInformacoes();

            elementoX.AlteraInformacoes();

            elementoX.MostrarInformacoes();

            Console.ReadKey();
        }
    }

    public class Teste
    {
        private int A { get; set; } = 0;
        private int B { get; set; } = 0;
        public Teste(int pA, int pB)  //é o construtor Teste(string pUsuario, string pSenha)
        {
            A = pA;
            B = pB;
        }

        public void AlteraInformacoes() //sobrecarga: funcções com o memso nome, porém, com parâmetros diferentes.
        {
            A = B * 100;
        }

        public void AlteraInformacoes(int pA, int pB)
        {
            A = pA * 2;
            B = pB * 2;
        }

        public void MostrarInformacoes()
        {
            Console.WriteLine(A + B);
        }
    }
}
