using Listar_meus_carros.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listar_meus_carros
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Carros> listaCarros = new List<Carros>();

            var opcaoMenu = MostraMenu();

            while (true)
            {
                switch (opcaoMenu)
                {
                    case 1: { AdicionarCarros(listaCarros); } break;
                    case 2: { ListarCarros(listaCarros); } break;
                    case 3: return;
                }

                opcaoMenu = MostraMenu();
            }
        }
        public static void AdicionarCarros(List<Carros> listaCarros)
        {

            for (int i = 0; i < 1; i++)
            {
                listaCarros.Add(new Carros()
                {
                    Modelo = RetornaValores("Modelo"),
                    Ano = int.Parse(RetornaValores("Ano")),
                    Placa = RetornaValores("Placa"),
                    CV = int.Parse(RetornaValores("CV"))
                });
            }

            ListarCarros(listaCarros);

        }

        public static void ListarCarros(List<Carros> listaCarros)
        {
            Console.WriteLine("\r\nListagem de carros");
            foreach (Carros item in listaCarros)
                Console.WriteLine($"Modelo:: {item.Modelo} Ano: {item.Ano} Placa: {item.Placa} CV: {item.CV}");

            Console.ReadKey();
        }

        public static string RetornaValores(string nome)
        {
            Console.WriteLine("");
            Console.WriteLine($"Informe o valor para o campo: {nome}");
            return Console.ReadLine();
        }

        public static int MostraMenu()
        {
            Console.Clear();
            Console.WriteLine("Selecione a opção desejada:" +
                "\r\n 1 - Adicionar veículos" +
                "\r\n 2 - Listar carros" +
                "\r\n 3 - Sair");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;
        }
    }
}
