using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarros2
{
    class Program
    {
        static string[,] baseDeCarros;
        static void Main(string[] args)
        {
            BaseDeDados();

            BemVindo();

            if (MenuInicial() == 1)
            {
                Console.Clear();

                MenuAlugarCarro();

            }

            Console.ReadKey();
        }

        public static void BaseDeDados()
        {
            baseDeCarros = new string[2, 3]
                {
                {"Uno", "1991", "sim"}, {"Agile", "2011", "não"}
                };

        }

        public static void BemVindo()
        {
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.WriteLine("<><>                                          <><>");
            Console.WriteLine("<><>  Bem Vindo a Locadora AMBEV Multimarcas  <><>");
            Console.WriteLine("<><>                                          <><>");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><>");
        }

        public static int MenuInicial()
        {
            Console.WriteLine("\r\nVocê deseja alugar um carro?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("0 - Não");
            Console.WriteLine("Digite o número desejado:");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;
        }

        public static void MenuAlugarCarro()
        {
            Console.WriteLine("<><><><><><><>>><><><><><><><><><><><><>");
            Console.WriteLine("<><>                                <><>");
            Console.WriteLine("<><>     Alugue um carro agora!     <><>");
            Console.WriteLine("<><>                                <><>");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><>");

            Console.WriteLine("\r\nDigite o modelo do carro a ser alugado");
            
            var modeloDoCarro = Console.ReadLine();

            if (PesquisaCarro(modeloDoCarro))
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

            public static bool PesquisaCarro(string modeloCarro)
            {

            }

        }           
}
