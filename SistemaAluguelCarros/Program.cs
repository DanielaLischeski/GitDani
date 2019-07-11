using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAluguelCarros
{
    class Program
    {
        static string[,] baseDeCarros;
        static void Main(string[] args)
        {
            BaseDeDados();
            
            SejaBemVindo();                    

            if (MenuAluguelInicial() == 1)
            {
                Console.Clear();

                MenuEscolhaCarro();
                
                //MenuEscolhaAno();                                            

            }

            Console.ReadKey();
           
        }

        /// <summary>
        /// Método que faz a saudação ao usuário
        /// </summary>
        public static void SejaBemVindo()
        {
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.WriteLine("<><>                                          <><>");
            Console.WriteLine("<><>  Bem Vindo a Locadora AMBEV Multimarcas  <><>");
            Console.WriteLine("<><>                                          <><>");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><>");
        }
           
        /// <summary>
        /// Método que cria a base de dados (modelo do carro, ano e disponibilidade).
        /// </summary>
        public static void BaseDeDados()
        {
            baseDeCarros = new string[2, 3]
            {
                {"Fusca","1979","não"}, {"Jeta","2018","sim"}
            };
        }

        /// <summary>
        /// Método que dá a opção para alugar um carro
        /// </summary>
        /// <returns>retrna sim ou não</returns>
        public static int MenuAluguelInicial() 
        {           
            Console.WriteLine("\r\nVocê deseja alugar um carro?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("0 - Não");
            Console.WriteLine("Digite o número desejado:");

            
            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao); 

            return opcao;
        }

        /// <summary>
        /// Método que permite pesquisar o modelo do carro.
        /// </summary>
        /// <param name="modeloDoCarro"></param>
        /// <returns></returns>
        public static bool PesquisaCarros(string modeloDoCarro)
        {
            

            for (int i = 0; i < baseDeCarros.GetLength(0); i++)
            {
                if (modeloDoCarro == baseDeCarros[i, 0]) //0 primeira coluna
                {
                    Console.WriteLine($"\r\nO carro: {modeloDoCarro} " + $" - Ano {baseDeCarros[i,1]}" + $" pode ser alugado?: {baseDeCarros[i, 2]}"); 

                    return baseDeCarros[i, 2] == "sim"; 
                }
            }

            return false; 
        }
               
        public static void AlugarCarro(string modeloCarro)
        {
            for (int i = 0; i < baseDeCarros.GetLength(0); i++)
            {
                if (modeloCarro == baseDeCarros[i, 0])
                    baseDeCarros[i, 2] = "não";
            }
        }

        public static void MenuEscolhaCarro()
        {

            Console.WriteLine("<><><><><><><>>><><><><><><><><><><><><>");
            Console.WriteLine("<><>                                <><>");
            Console.WriteLine("<><>     Alugue um carro agora!     <><>");
            Console.WriteLine("<><>                                <><>");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><>");

            Console.WriteLine("\r\nDigite o modelo do carro a ser alugado");


            var modeloDoCarro = Console.ReadLine();
            if (PesquisaCarros(modeloDoCarro))
            {
                Console.Clear();
                Console.WriteLine("Você deseja alocar o carro? Para sim (1) para não (0)");

                if (Console.ReadKey().KeyChar.ToString() == "1")
                {
                    AlugarCarro(modeloDoCarro);
                    Console.Clear();
                    Console.WriteLine("<><><><><><><><><><><><><><><><><><><>");
                    Console.WriteLine("<><>                              <><>");
                    Console.WriteLine("<><>  Carro alugado com sucesso!  <><>");
                    Console.WriteLine("<><>                              <><>");
                    Console.WriteLine("<><><><><><><><><><><><><><><><><><><>");
                }

                else
                    Console.Clear();

                Console.WriteLine("\r\nListagem de carros:");

                for (int i = 0; i < baseDeCarros.GetLength(0); i++)
                {
                    Console.WriteLine($"Nome: {baseDeCarros[i, 0]}  - Ano {baseDeCarros[i, 1]} Disponível: {baseDeCarros[i, 2]}");
                }

            }
        }
                     
    }
}
