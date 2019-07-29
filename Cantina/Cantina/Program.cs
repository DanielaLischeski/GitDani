using Cantina.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina
{
    class Program
    {
        static void Main(string[] args)
        {
            Carteira carteiraAluno = new Carteira();

            while (carteiraAluno.Saldo > 0)
            {
                if (carteiraAluno.Comprar())
                    Console.WriteLine("Compra realizada com sucesso!");
                else
                    Console.WriteLine("Compra não realizada, saldo insuficiente.");

                Console.WriteLine($"Saldo atual disponível: {carteiraAluno.Saldo.ToString("N2")}"); //N2 mostra 2 casas após a vírgula

                Console.ReadKey();
            }
        }
    }
}
