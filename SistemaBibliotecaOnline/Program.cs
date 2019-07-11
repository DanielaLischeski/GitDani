using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBibliotecaOnline
{
    class Program
    {
        static string[,] baseDeLivros; //baseDeLivros é uma variável global, utilizada por todo código.
        static void Main(string[] args)
        {
            CarregaBaseDeDados();

            MostrarSejaBemVindo();
            
            if (MenuInicial() == 1)
            {
                MostrarMenuAlocacao();
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Método que mostra a informações iniciais do sistema. O método void não retorna nada.
        /// </summary>
        public static void MostrarSejaBemVindo()
        {
            Console.WriteLine("________________________________________________");
            Console.WriteLine("       Sistema de alocação de livros.");
            Console.WriteLine("________________________________________________");
            Console.WriteLine("    Desenvolvido por Desenvolvedores.ME         ");
            Console.WriteLine("________________________________________________");

        }
        
        /// <summary>
        /// Método que mostra o conteúdo do menu e as opções de escolha.
        /// </summary>
        /// <returns>Retorna o valor do menu escolhido em um tipo inteiro.</returns>
        public static int MenuInicial() //int irá ter um retorno, o método void não tem retorno
        {
            Console.WriteLine("\r\nMenu - Inicial");
            Console.WriteLine("O que você deseja realizar?");
            Console.WriteLine("1 - Alocar um livro.");
            Console.WriteLine("2 - Sair do sistema");
            Console.WriteLine("Digite o número desejado:");

            //var  opcao = Console.ReadKey().KeyChar.ToString();  //KeyChar é uma representação, um código na memória. ToString traduz o KeyChar para String.
            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao); //faz o mesmo que a linha acima

            return opcao;
        }

        /// <summary>
        /// Método que carrega a base de dados dentro do sistema.
        /// </summary>
        public static void CarregaBaseDeDados()
        {
            baseDeLivros = new string[2, 2]
            {
                {"O pequeno","sim" },
                {"O grande","não" }
            };
        }

        /// <summary>
        /// Método que retorna se um livro pode ser alocado.
        /// </summary>
        /// <param name="nomeLivro">Nome do livro a ser pesquisado</param>
        /// <returns>Retorna verdadeiro caso o livro estiver livre para alocação.</returns>
        public static bool PesquisaLivroParaAlocacao(string nomeLivro)  //definiu nomeLivro, porque ainda não havia sido referenciada
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (nomeLivro == baseDeLivros[i, 0]) //0 primeira coluna
                {
                    Console.WriteLine($"O livro: {nomeLivro} " + $" pode ser alocado?: {baseDeLivros[i, 1]}"); //1 segunda coluna

                    return baseDeLivros[i, 1] == "sim"; //se a baseDeLivros for sim, armazena o valor e poderá alocar o livro. Quando acha o livro já retorna, pois não precisa passar por todos os livros
                }
            }

            return false; //se passa pla rotina anterior e não encontra o livro, retorna falso, pois não tem como alocar.
        }

        /// <summary>
        /// Método que aloca o livro de acordo com o parâmetro passado.
        /// </summary>
        /// <param name="nomeLivro">Nome do livro a ser alocado.</param>
        public static void AlocarLivro(string nomeLivro)
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (nomeLivro == baseDeLivros[i, 0])
                    baseDeLivros[i, 1] = "não";
            }
        }

        /// <summary>
        /// Método que carrega o conteúdo inicial da aplicação do menu 1.
        /// </summary>
        public static void MostrarMenuAlocacao()
        {
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine("Menu - Alocação de livros");
            Console.WriteLine("Digite o nome do livro a ser alocado :");

            var nomedolivro = Console.ReadLine();
            if (PesquisaLivroParaAlocacao(nomedolivro))
            {
                Console.Clear();
                Console.WriteLine("Você deseja alocar o livro? Para sim (1) para não (0)");

                if (Console.ReadKey().KeyChar.ToString() == "1")
                {
                    AlocarLivro(nomedolivro);
                    Console.Clear();
                    Console.WriteLine("Livro Alocado com sucesso!");
                }

                else
                    Console.Clear();

                Console.WriteLine("Listagem de livros:");

                for (int i = 0; i < baseDeLivros.GetLength(0); i++)
                {
                    Console.WriteLine($"Nome: {baseDeLivros[i, 0]} Disponível: {baseDeLivros[i, 1]}");
                }

            }
        }
    }
}
