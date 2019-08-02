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
            string[,] listaDeCarro = new string[2, 4];

            int IdParaLista = 0;

            InsereRegistro(ref listaDeCarro, ref IdParaLista);

            Console.ReadKey();

            InsereRegistro(ref listaDeCarro, ref IdParaLista);

            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que insere novo registro dentro da nossa lista 
        /// </summary>
        /// <param name="listaDeCarro">Nossa lista de nomes vazia ou não</param>
        /// <param name="IdParaLista">Nossa referencia externa de id</param>
        public static void InsereRegistro(ref string[,] listaDeCarro, ref int IdParaLista)
        {

            for (int i = 0; i < listaDeCarro.GetLength(0); i++)
            {
                if (listaDeCarro[i, 0] != null)
                    continue;
                Console.WriteLine("\r\nInforma o modelo de carro para adicionar um registro:");
                var modelo = Console.ReadLine();

                Console.WriteLine("\r\nInforma o ano para adicionar um registro:");
                var ano = Console.ReadLine();

                Console.WriteLine("\r\nInforma a cor do carro para adicionar um registro:");
                var cor = Console.ReadLine();

                listaDeCarro[i, 0] = (IdParaLista++).ToString();
                listaDeCarro[i, 1] = modelo;
                listaDeCarro[i, 2] = ano;
                listaDeCarro[i, 3] = cor;

                Console.WriteLine("\r\nDeseja inserir um novo registro? sim(1) ou não(0)");

                var continuar = Console.ReadKey().KeyChar.ToString();

                if (continuar == "0")
                    break;

                AumentaTamanhoLista(ref listaDeCarro);
            }

            Console.WriteLine("\r\nRegistro adicionados com sucesso, segue lista de informações adicionadas:");


            for (int i = 0; i < listaDeCarro.GetLength(0); i++)

                Console.WriteLine(string.Format("    Registro ID {0} - Nome: {1} - Ano: {2} - Cor: {3}", listaDeCarro[i, 0], listaDeCarro[i, 1], listaDeCarro[i, 2], listaDeCarro[i, 3]));
        }

        public static void AumentaTamanhoLista(ref string[,] ListaDeCarro)
        {

            var limiteDaLista = true;

            for (int i = 0; i < ListaDeCarro.GetLength(0); i++)
            {

                if (ListaDeCarro[i, 0] == null)
                    limiteDaLista = false;
            }

            if (limiteDaLista)
            {
                var listaCopia = ListaDeCarro;

                ListaDeCarro = new string[ListaDeCarro.GetLength(0) + 2, 4];

                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    ListaDeCarro[i, 0] = listaCopia[i, 0];

                    ListaDeCarro[i, 1] = listaCopia[i, 1];

                    ListaDeCarro[i, 2] = listaCopia[i, 2];

                    ListaDeCarro[i, 3] = listaCopia[i, 3];
                }

                Console.WriteLine("\r\nO tamanho da lista foi atualizado.");
              
            }
                      
        }        

    }
}
