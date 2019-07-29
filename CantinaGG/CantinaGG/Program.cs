using CantinaGG.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantinaGG
{
    class Program
    {
        static void Main(string[] args)
        {/*/*/
            Carteira lanche = new Carteira(20);

            while (lanche.Saldo > 0)
            {
                MostrarMenu();

                var opcaoEscolhida = Console.ReadLine();
                var valor = 0.00;

                //ou switch(Console.ReadLine()) e retira var opcaoEscolhida = Console.ReadLine();
                switch (opcaoEscolhida)
                {
                    case "1": { valor = 3.50; } break;
                    case "2": { valor = 5.00; } break;
                    case "3": { valor = 3.80; } break;
                    case "4": { valor = lanche.Saldo; } break;
                }

                if (lanche.PoderDeComprarLanches(valor))
                    Console.WriteLine("Você comprou o lanche selecionado.");
                else
                    Console.WriteLine("O lanche não pode ser comprado");

                Console.WriteLine($"Você ainda possui R${lanche.Saldo}");
                Console.ReadKey();

            }

            Console.WriteLine("Acabou o dinheiro");
            Console.ReadKey();

        }

        public static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("Lanches disponíveis" +
                "\r\n 1 - Pastel R$3,50" +
                "\r\n 2 - Bolinho de carne R$5,00" +
                "\r\n 3 - Coxinha R$3,80" +
                "\r\n 4 - Doar o restante para caridade" +
                "\r\n Escolha uma das opções acima:");
        }
    }
}
