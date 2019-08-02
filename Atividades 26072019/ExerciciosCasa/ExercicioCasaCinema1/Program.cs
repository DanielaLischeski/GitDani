using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCasaCinema1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repete = true;

            while (repete)
            {

                Console.WriteLine("O que você deseja assistir?");
                string nome = Console.ReadLine();


                if (nome.ToLower().Replace("é", "e") == "serie")
                {
                    Console.WriteLine("\r\nQual desses gêneros você prefere?");
                    Console.WriteLine("1 - Ação");
                    Console.WriteLine("2 - Terror");

                    //int escolha;
                    //int.TryParse(Console.ReadLine(), out escolha);
                    int.TryParse(Console.ReadLine(), out int escolha);

                    if (escolha == 1)
                    {
                        Console.WriteLine("\r\nPara o gênero ação indicamos a série: Punisher");
                        repete = false;
                    }
                    else if (escolha == 2)
                    {
                        Console.WriteLine("\r\nPara o terror indicamos a série: Bagulhos Sinistros");
                        repete = false;
                    }
                    else
                    {
                        Console.WriteLine("Realize nova busca");
                    }


                }
                else if (nome.ToLower() == "filme")
                {
                    Console.WriteLine("\r\nDesculpe, estamos sem filmes no momento!");

                }
                else
                {
                    Console.WriteLine("\r\nDesculpe, realize nova busca");

                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
