using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O que você deseja assistir?");


            string[,] BaseCinema = new string[5, 3] {
            {"Filme", "Comédia", "Loucademia de polícia"},
            {"Filme", "Ação", "Duro de matar"},
            {"Série", "Ação", "The Punisher"},
            {"Série", "Ficção", "Jurassic Park"},
            {"Série", "Terror", "Bagulos Sinistros"}
            };

            // pega a respsota do usuario
            string resposta1 = Console.ReadLine().ToString().ToLower().Replace("é", "e");

            // avisa as opcoes disponiveis para a resposta
            Console.WriteLine("\r\nTemos as seguintes opções de gênero de " + resposta1 + ":");

            for (int i = 0; i < BaseCinema.GetLength(0); i++)
            {
                if (BaseCinema[i, 0].ToString().ToLower().Replace("é", "e") == resposta1)
                    Console.WriteLine(BaseCinema[i, 1]);
            }

            Console.WriteLine("Informe o gênero desejado");
            string genero = Console.ReadLine().ToString().ToLower().Replace("ã", "a").Replace("ç", "c");

            for (int i = 0; i < BaseCinema.GetLength(0); i++)
            {
                if (BaseCinema[i, 0].ToString().ToLower().Replace("é", "e") == resposta1 && BaseCinema[i, 1].ToLower().Replace("ã", "a").Replace("ç", "c") == genero)
                    Console.WriteLine("\r\nPara " + resposta1 + " do gênero " + genero + " temos: " + BaseCinema[i, 2]);
            }

            Console.ReadKey();
        }
    }
}
