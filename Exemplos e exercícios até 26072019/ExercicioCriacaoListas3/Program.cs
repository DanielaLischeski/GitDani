using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCriacaoListas3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] listaDeLivro = new string[2, 3];

            int IdParaLista = 0;

            InsereRegistro(ref listaDeLivro, ref IdParaLista);

            Console.ReadKey();

            InsereRegistro(ref listaDeLivro, ref IdParaLista);

            Console.ReadKey();

        }

        public static void InsereRegistro(ref string[,] listaDeLivro, ref int IdParaLista)
        {
            for (int i = 0; i < listaDeLivro.GetLength(0); i++)
            {
                if (listaDeLivro[i, 0] != null)
                 continue;

                Console.WriteLine("\r\nInforma o nome do livro para adicionar um registro:");
                var livro = Console.ReadLine();

                Console.WriteLine("\r\nInforma o nome do autor para adicionar um registro:");
                var autor = Console.ReadLine();

                Console.WriteLine("\r\nInforma o número de páginas do livro para adicionar um registro:");
                var paginas = Console.ReadLine();

                listaDeLivro[i, 0] = (IdParaLista++).ToString();
                listaDeLivro[i, 1] = livro;
                listaDeLivro[i, 2] = autor;
                listaDeLivro[i, 3] = paginas;

                Console.WriteLine("\r\nDeseja inserir um novo registro? sim(1) ou não(0)");

                var continuar = Console.ReadKey().KeyChar.ToString();

                if (continuar == "0")
                    break;
            }

            Console.WriteLine("\r\nRegistro adicionados com sucesso, segue lista de informações adicionadas:");

            for (int i = 0; i < listaDeLivro.GetLength(0); i++)
                Console.WriteLine(string.Format("    Registro ID {0} - Livro: {1} - Autor: {2} - Número de páginas: {3}", listaDeLivro[i, 0], listaDeLivro[i, 1], listaDeLivro[i, 2], listaDeLivro[i, 3]));

        }
    }
}
