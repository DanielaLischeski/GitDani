using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTeste1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] baseDeLivros = new string[2, 5];

            int IdBaseDeLivros = 0;

            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><<>><><<><>");
            Console.WriteLine("<><><><>                                                   <><><><>");
            Console.WriteLine("<><><><>         Iniciando sistema de biblioteca           <><><><>");
            Console.WriteLine("<><><><>                                                   <><><><>");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><<>><><<><>");
            Console.WriteLine("\r\n Informe qualquer tecla para continuar");

            Console.ReadKey();

            var escolhaInicial = ApresentaMenuInicial();


            while (true)
            {
                switch (escolhaInicial)
                {
                    case "1": { InsereValoresNaLista(ref baseDeLivros, ref IdBaseDeLivros); } break;
                    case "2": { RemoverInformacoes(ref baseDeLivros); } break;
                    case "3": { MostrarInformacoes(baseDeLivros); } break;                   
                    case "4": { return; }

                }

                escolhaInicial = ApresentaMenuInicial();
            }
        }

        /// <summary>
        /// Apresenta as informações do menu inicial.
        /// </summary>
        /// <returns>Retorna o menu escolhido.</returns>
        public static string ApresentaMenuInicial()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("------------------Menu-------------------");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine(" 1 - Inserir um novo livro na base.");
            Console.WriteLine(" 2 - Remover um livro da base.");
            Console.WriteLine(" 3 - Listar informações.");           
            Console.WriteLine(" 4 - Sair do sistema.");

            Console.WriteLine(" Digite o número da opção desejada:");

            return Console.ReadLine();
        }

        /// <summary>
        /// Método que insere informações dentro da nossa base de dados
        /// </summary>
        /// <param name="baseDeLivros">Base de dados como ref para alterar para todos os métodos</param>
        /// <param name="indiceBase">Índice da nossa base com ref para alterar para todos os métodos</param>
        public static void InsereValoresNaLista(ref string[,] baseDeLivros, ref int indiceBase)
        {
            Console.WriteLine("---------Inserindo livro na basede dados da biblioteca----------");

            Console.WriteLine("Informe o nome do livro:");

            var nomeLivro = Console.ReadLine();

            AumentaTamanhoLista(ref baseDeLivros);

            Console.WriteLine("Informe o nome do autor:");

            var nomeAutor = Console.ReadLine();

            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (baseDeLivros[i, 0] != null)
                    continue;

                baseDeLivros[i, 0] = (indiceBase++).ToString();
                baseDeLivros[i, 1] = nomeLivro;
                baseDeLivros[i, 2] = nomeAutor;
                baseDeLivros[i, 3] = "true";
                baseDeLivros[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                break;
            }

            Console.WriteLine("\r\nLivro cadastrado com sucesso!");
            Console.WriteLine(">>---->> Para voltar ao menu inicial informe qualquer tecla.");
            Console.ReadKey();

        }

        /// <summary>
        /// Mostra as informações dentro da nossa lista de dados "base de dados"
        /// </summary>
        /// <param name="baseDeLivros">base de dados para a leitura e mostrar pro usuário</param>
        /// <param name="mostrarRegistrosNAtivos">Quando identificado com o valor true, o mesmo mostra os valores que não estão ativos dentro do sistema</param>
        public static void MostrarInformacoes(string[,] baseDeLivros, string mostrarRegistrosNAtivos = "false")
        {
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("Apresentação das informações dentro da base de dados da biblioteca.");
            Console.WriteLine("*******************************************************************");

            if (mostrarRegistrosNAtivos == "true")
                Console.WriteLine("Registros desativados dentro do sistema.");               

            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (baseDeLivros[i, 3] != mostrarRegistrosNAtivos)
                    Console.WriteLine($"ID {baseDeLivros[i, 0]} " +
                        $" - Título do livro: {baseDeLivros[i, 1]}" +
                        $" - Nome do autor: {baseDeLivros[i, 2]}" +
                        $" - Data alteração:{baseDeLivros[i, 4]}");
            }

            Console.WriteLine("\r\nResultados apresentados com sucesso!");
            Console.WriteLine("\r\nPara voltar ao menu inicial informe qualquer tecla.");
            Console.ReadKey();
        }

        /// <summary>
        /// Método utilizado para remover um registro pelo id dentro do sistema
        /// </summary>
        /// <param name="baseDeLivros">Base de dados em que ele irá remover o registro pelo id</param>
        public static void RemoverInformacoes(ref string[,] baseDeLivros)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Área de remoção de registro do sistema.");
            Console.WriteLine("---------------------------------------");

            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (baseDeLivros[i, 3] != "false")
                    Console.WriteLine($"ID: {baseDeLivros[i, 0]}" +
                        $" - Título do livro: {baseDeLivros[i, 1]}" +
                        $" - Nome do autor: {baseDeLivros[i, 2]}");
            }

            Console.WriteLine("\r\n Informe o ID do registro a se removido:");
            var id = Console.ReadLine();

            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (baseDeLivros[i, 0] != null && baseDeLivros[i, 0] == id)
                {
                    baseDeLivros[i, 3] = "false";
                    baseDeLivros[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                }

            }

            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("     Livro removido da base da biblioteca     ");
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
            Console.WriteLine("\r\nPara retornar ao menu inicial informe qualquer tecla.");
            Console.ReadKey();
        }

        /// <summary>
        /// Método que aumenta as informações disponíveis para cadastro dentro da nossa lista///
        /// </summary>
        /// <param name="baseDeLivros">Retorna nossa base de dados</param>
        public static void AumentaTamanhoLista(ref string[,] baseDeLivros)
        {
            var limiteDaLista = true;

            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (baseDeLivros[i, 0] == null)
                    limiteDaLista = false;
            }

            if (limiteDaLista)
            {
                var listaCopia = baseDeLivros; //faz uma cópia da base de livros  para mostrar ao usuário após apagar os registros.

                baseDeLivros = new string[baseDeLivros.GetLength(0) + 2, 5];


                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    baseDeLivros[i, 0] = listaCopia[i, 0];
                    baseDeLivros[i, 1] = listaCopia[i, 1];
                    baseDeLivros[i, 2] = listaCopia[i, 2];
                    baseDeLivros[i, 3] = listaCopia[i, 3];
                    baseDeLivros[i, 4] = listaCopia[i, 4];
                }

                Console.WriteLine("\r\n **** O tamanho da lista foi atualizado. ****");
            }
        }
    }
}
