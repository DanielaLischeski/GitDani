﻿using System;
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

            var opcaoMenu = MenuPrincipal();

            while (opcaoMenu != 3)  //enquanto o usuário não digitar 3 sempre volta pro menu
            {
                if (opcaoMenu == 1)
                    AlugarUmCarro(); //LocarUmLivro

                if (opcaoMenu == 2)
                    DevolverCarro(); //DesalocarUmLivro

                opcaoMenu = MenuPrincipal();
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

        public static int MenuPrincipal() //int irá ter um retorno, o método void não tem retorno
        {
            Console.Clear();

            SejaBemVindo();
            
            Console.WriteLine("Menu - Inicial");
            Console.WriteLine("O que você deseja realizar?");
            Console.WriteLine("1 - Alugar um carro.");
            Console.WriteLine("2 - Devolver um carro.");
            Console.WriteLine("3 - Sair do sistema");
            Console.WriteLine("Digite o número desejado:");

            //var  opcao = Console.ReadKey().KeyChar.ToString();  //KeyChar é uma representação, um código na memória. ToString traduz o KeyChar para String.
            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao); //faz o mesmo que a linha acima

            return opcao;
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

        public static void AlugarUmCarro()
        {

            MostrarMenuInicialCarros("Alugar um carro:");

            var modeloDoCarro = Console.ReadLine();
            if (PesquisaCarros(modeloDoCarro))
            {
                Console.Clear();
                SejaBemVindo();
                Console.WriteLine("Você deseja alugar um carro? Para sim (1) para não (0)");

                AtualizarCarro(modeloDoCarro, Console.ReadKey().KeyChar.ToString() == "1");

                MostrarListaDeCarros();

                Console.ReadKey();

            }
        }

        public static void AtualizarCarro(string modeloCarro, bool alugar)
        {
            for (int i = 0; i < baseDeCarros.GetLength(0); i++)
            {
                if (modeloCarro == baseDeCarros[i, 0])
                    baseDeCarros[i, 2] = alugar? "não" : "sim";
            }
        }

        public static void MostrarListaDeCarros()
        {
            
            Console.WriteLine("\r\nListagem de carros:");

            for (int i = 0; i < baseDeCarros.GetLength(0); i++)
            {
                Console.WriteLine($"Nome: {baseDeCarros[i, 0]} - Ano {baseDeCarros[i,1]} Disponível: {baseDeCarros[i, 2]}");
            }
        }

        public static void DevolverCarro()
        {
            MostrarMenuInicialCarros("Devolver um carro:");

            MostrarListaDeCarros();

            var modeloDoCarro = Console.ReadLine();
            if (!PesquisaCarros(modeloDoCarro))
            {
                Console.Clear();
                SejaBemVindo();
                Console.WriteLine("Você deseja devolver um carro? Para sim (1) para não (0)");

                AtualizarCarro(modeloDoCarro, Console.ReadKey().KeyChar.ToString() == "0");

                MostrarListaDeCarros();

                Console.ReadKey();

            }

        }

        public static void MenuEscolhaCarro()
        {

            MostrarMenuInicialCarros("Devolver um carro");

            MostrarListaDeCarros();


            var modeloDoCarro = Console.ReadLine();
            if (PesquisaCarros(modeloDoCarro))
            {              
                Console.Clear();
                SejaBemVindo();
                Console.WriteLine("Você deseja devolver um carro? Para sim (1) para não (0)");

                AtualizarCarro(modeloDoCarro, Console.ReadKey().KeyChar.ToString() == "0");

                MostrarListaDeCarros();

                Console.ReadKey();

            }
        }
                     
        public static void MostrarMenuInicialCarros(string operacao)
        {
            Console.Clear();

            SejaBemVindo();

            Console.WriteLine($"Menu - {operacao}");
            Console.WriteLine("Digite o modelo do carro para realizar a operação:");
        }
    }
}