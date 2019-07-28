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
                        
            var opcaoMenu = MenuPrincipal();

            while(opcaoMenu != 3)  //enquanto o usuário não digitar 3 sempre volta pro menu
            {
                if(opcaoMenu == 1)
                    AlocarUmLivro();

                if (opcaoMenu == 2)
                    DesalocarUmLivro();

                opcaoMenu = MenuPrincipal();
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
        public static int MenuPrincipal() //int irá ter um retorno, o método void não tem retorno
        {
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine("Menu - Inicial");
            Console.WriteLine("O que você deseja realizar?");
            Console.WriteLine("1 - Alocar um livro.");
            Console.WriteLine("2 - Devolver um livro.");
            Console.WriteLine("3 - Sair do sistema");
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
        public static bool? PesquisaLivroParaAlocacao(ref string nomeLivro)  //definiu nomeLivro, porque ainda não havia sido referenciada
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (CompararNomes(nomeLivro, baseDeLivros[i, 0]))
                //(nomeLivro.ToLower().Replace(" ","") == baseDeLivros[i, 0].ToLower().Replace(" ","")) //0 primeira coluna  
                {   //ToLower substitur tudo para minúsculo  /Replace substitui um por outro
                    Console.WriteLine($"O livro: {nomeLivro} " + $" pode ser alocado?: {baseDeLivros[i, 1]}"); //1 segunda coluna

                    return baseDeLivros[i, 1] == "sim"; //se a baseDeLivros for sim, armazena o valor e poderá alocar o livro. Quando acha o livro já retorna, pois não precisa passar por todos os livros
                }
            }

            Console.WriteLine("Nenhum livro encontrado. Deseja realizar a busca novamente?");
            Console.WriteLine("Digite o número da opção desejada: sim(1) não(0)");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao); 
                        
            if(opcao == 1)
            {
                Console.WriteLine("Digite o nome do livro a ser pesquisado:");
                nomeLivro = Console.ReadLine();

                return PesquisaLivroParaAlocacao(ref nomeLivro);
            }

            return null; //se passa pla rotina anterior e não encontra o livro, retorna falso, pois não tem como alocar.
        }

        /// <summary>
        /// Método para alterar a informação de alocação do livro.
        /// </summary>
        /// <param name="nomeLivro">Nome do livro a ser alocado.</param>
        /// <param name = "alocar">Valor booleano que define se o livro está ou não disponível.</param>
        public static void AlocarLivro(string nomeLivro, bool alocar)
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (nomeLivro == baseDeLivros[i, 0])
                {
                    baseDeLivros[i, 1] = alocar? "não" : "sim"; //alocar? é o mesmo que: alocar == true, ou seja, se alocar fr verdadeiro vai responder "não", senaõ responde "sim"
                }
            }

            Console.Clear();
            MostrarSejaBemVindo();
            Console.WriteLine("Livro atualizado com sucesso!");
        }

        /// <summary>
        /// Método que carrega o conteúdo inicial da aplicação do menu 1.
        /// </summary>
        public static void AlocarUmLivro()
        {

            MostrarMenuInicialLivros("Alocar um livro:");

            var nomedolivro = Console.ReadLine();
            var resultadoPesquisa = PesquisaLivroParaAlocacao(ref nomedolivro);

            if (resultadoPesquisa != null && resultadoPesquisa == true)
            {
                Console.Clear();
                MostrarSejaBemVindo();
                Console.WriteLine("Você deseja alocar o livro? Para sim (1) para não (0)");                       
               
                AlocarLivro(nomedolivro, Console.ReadKey().KeyChar.ToString() == "1");                    
                
                MostrarListaDeLivros();

                Console.ReadKey();            
            }

            if(resultadoPesquisa == null)
            {
                Console.WriteLine("Nenhum livro encontrado em nossa base de dados do sistema.");
            }
        }

        /// <summary>
        /// Método que mostra a lista de livros atualizada
        /// </summary>
        public static void MostrarListaDeLivros()
        {
            Console.WriteLine("Listagem de livros:");

            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                Console.WriteLine($"Nome: {baseDeLivros[i, 0]} Disponível: {baseDeLivros[i, 1]}");
            }
        }

        public static void DesalocarUmLivro()
        {
            MostrarMenuInicialLivros("Desalocar um livro:");

            MostrarListaDeLivros();

            var nomedolivro = Console.ReadLine();
            var resultadoPesquisa = PesquisaLivroParaAlocacao(ref nomedolivro);

            if (resultadoPesquisa != null && resultadoPesquisa == false)
            {
                Console.Clear();
                MostrarSejaBemVindo();
                Console.WriteLine("Você deseja desalocar o livro? Para sim (1) para não (0)");

                AlocarLivro(nomedolivro, Console.ReadKey().KeyChar.ToString() == "0");

                MostrarListaDeLivros();

                Console.ReadKey();
            }

            if (resultadoPesquisa == null)
            {
                Console.WriteLine("Nenhum livro encontrado em nossa base de dados do sistema.");
            }
        }

        public static void MostrarMenuInicialLivros(string operacao)
        {
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine($"Menu - {operacao}");
            Console.WriteLine("Digite o nome do livro para realizar a operação:");
        }

        /// <summary>
        /// Método que compara duas strings em caixa baixa e remove espaços varios dentro da mesma.
        /// </summary>
        /// <param name="primeiro">Primeira string a se comparada</param>
        /// <param name="segundo">Segunda string a ser comparad</param>
        /// <returns>Restorna o resultado desta comparação</returns>
        public static bool CompararNomes (string primeiro, string segundo)
        {
            if (primeiro.ToLower().Replace(" ", "")
                == segundo.ToLower().Replace(" ", ""))
                return true;

            return false;
        }
    }
}
