using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina.Classes
{
    public class Carteira
    {
        double saldo = 0;

        public double Saldo { get { return saldo; } }

        public Carteira()
        {
            saldo = 20;
        }       
              

        public double MostrarSaldo()
        {
            return saldo;
        }
              

        public double MenuLanches()
        {
            Console.WriteLine($"-------Menu Lanches--------" +
                $"\r\n 1 - Coxinha...............R$3,00" +
                $"\r\n 2 - Pastel de queijo......R$2,50" +
                $"\r\n 3 - Cachorro quente.......R$5,00" +
                $"\r\nQual a opção desejada?");

            var opcaoEscolhida = Console.ReadLine();

            switch(opcaoEscolhida)
            {
                case "1": { return 3.00; } //"1" porque Console.ReadLine() é string
                case "2": { return 2.50; }
                case "3": { return 5.00; }
            }
            return 0.00;
        }

        public bool Comprar()
        {
            var lancheEscolhido = MenuLanches();

            if (lancheEscolhido <= saldo)
            {
                saldo -= lancheEscolhido;
                return true;
            }
            return false;
        }
    }
}
