using ListaTipada.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTipada
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Lanche> minhaLista = new List<Lanche>();

            for (int i = 0; i < 5; i++)
            {
                //Console.WriteLine("Insira as informações do lanche, quantidade e valor:");
                minhaLista.Add(new Lanche()
                {
                    //Nome = Console.ReadLine(),
                    Nome = RetornaValores("Nome"),
                    //Quantidade = int.Parse(Console.ReadLine()),
                    Quantidade = int.Parse(RetornaValores("Quantidade")),
                    //Valor = double.Parse(Console.ReadLine())
                    Valor = double.Parse(RetornaValores("Valor"))
                });

            }

            foreach (Lanche item in minhaLista)
                Console.WriteLine($"Lanche: {item.Nome} Quantidade: {item.Quantidade} Valor: {item.Valor}");

           Console.ReadKey();
        }

        /// <summary>
        /// Método que mostra uma interface legal para adicionar valores
        /// </summary>
        /// <param name="nome">Nome do campo que irá retornar o valor</param>
        /// <returns>Retorna uma string com o valor</returns>
        public static string RetornaValores(string nome)
        {
            //informo e retorno o valor comnforme solicitação do campo
            Console.WriteLine($"Informe o valor para o campo: {nome}");
            return Console.ReadLine();
        }
    }
}
