using MinhaPrimeiraListaTipada.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraListaTipada
{
    class Program
    {
        static void Main(string[] args)
        {
            //O indicador <T> indica o tipo da minha lista, com isso temos uma lista de lanches.
            List<Lanche> minhaLista = new List<Lanche>()
            {
                //Adiciono na minha lista~pão de queijo
               new Lanche()
                {
                    Nome = "Pão de queijo",
                    Quantidade = 9,
                    Valor = 1.85
                },

               new Lanche()
                {
                    Nome = "Bolinho de carne + mini refri",
                    Quantidade = 2,
                    Valor = 7.50
                },

                new Lanche()
                {
                    Nome = "Coxinha",
                    Quantidade = 5,
                    Valor = 4.00
                },

                new Lanche()
                {
                    Nome = "Pastel de palmito",
                    Quantidade = 7,
                    Valor = 3.70
                },

               new Lanche()
                {
                    Nome = "Pastel de queijo",
                    Quantidade = 5,
                    Valor = 3.00
                },

               new Lanche()
                {
                    Nome = "Fatia de pizza",
                    Quantidade = 2,
                    Valor = 7.80
                }
             };

            //Aqui ando pela minha lista para poder apresentar em tela os valores
            //item in significa que ele já é um índice da minha lista bonitinho
            foreach (Lanche item in minhaLista)
                Console.WriteLine($"Lanches disponíveis: {item.Nome}");

            Console.WriteLine("Removendo item");

            foreach(Lanche item in minhaLista)
            {
                if (item.Quantidade == 2)
                {
                    minhaLista.Remove(item); //vai remover todos os íten = 2
                    break;
                }
            }

          //Abaixo realiza também operação de remover ítens, potrém, mais avançado. É semelhante ao foreach acima.
          // //Aqui remove só o primeiro idem = 2
          // minhaLista.Remove(minhaLista.FirstOrDefault(x => x.Quantidade == 2)); //remove se a quantidade for 2
          //
          // //Aqui retorna todos os itens = 2
          // var meuItem = (from item in minhaLista
          //                where item.Quantidade == 2
          //                select item).ToList<Lanche>();

            foreach (Lanche item in minhaLista)
                Console.WriteLine($"Lanches disponíveis: {item.Nome}");

            Console.ReadKey();
        }
    }
}
