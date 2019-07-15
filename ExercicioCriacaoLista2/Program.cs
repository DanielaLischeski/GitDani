using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCriacaoLista2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] listaDeNome = new string[2, 3];

            int IdParaLista = 0;

            InsereRegistro(ref listaDeNome, ref IdParaLista);

            Console.ReadKey();

            InsereRegistro(ref listaDeNome, ref IdParaLista);

            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que insere novo registro dentro da nossa lista 
        /// </summary>
        /// <param name="listaDeNome">Nossa lista de nomes vazia ou não</param>
        /// <param name="IdParaLista">Nossa referencia externa de id</param>
        public static void InsereRegistro(ref string[,] listaDeNome, ref int IdParaLista)
        {

            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                if (listaDeNome[i, 0] != null)
                    continue;
                Console.WriteLine("\r\nInforma um nome para adicionar um registro:");
                var nome = Console.ReadLine();

                Console.WriteLine("\r\nInforma uma idade para adicionar um registro:");
                var idade = Console.ReadLine();

                listaDeNome[i, 0] = (IdParaLista++).ToString();

                listaDeNome[i, 1] = nome;

                listaDeNome[i, 2] = idade;

                Console.WriteLine("Deseja inserir um novo registro? sim(1) ou não(0)");

                var continuar = Console.ReadKey().KeyChar.ToString();

                if (continuar == "0")
                    break;

                AumentaTamanhoLista(ref listaDeNome);
            }

            Console.WriteLine("Registro adicionados com sucesso, segue lista de informações adicionadas:");


            for (int i = 0; i < listaDeNome.GetLength(0); i++)

                Console.WriteLine(string.Format("Registro ID {0} - Nome:{1} - Idade: {2}", listaDeNome[i, 0], listaDeNome[i, 1], listaDeNome[i, 2]));
        }

        public static void AumentaTamanhoLista(ref string[,] ListaDeNome)
        {

            var limiteDaLista = true;

            for (int i = 0; i < ListaDeNome.GetLength(0); i++)
            {

                if (ListaDeNome[i, 0] == null)
                    limiteDaLista = false;
            }


            if (limiteDaLista)
            {

                var listaCopia = ListaDeNome;

                ListaDeNome = new string[ListaDeNome.GetLength(0) + 5, 3];

                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    ListaDeNome[i, 0] = listaCopia[i, 0];

                    ListaDeNome[i, 1] = listaCopia[i, 1];

                    ListaDeNome[i, 2] = listaCopia[i, 2];
                }

                Console.WriteLine("O tamanho da lista foi atualizado.");
            }

        }
    }
}
