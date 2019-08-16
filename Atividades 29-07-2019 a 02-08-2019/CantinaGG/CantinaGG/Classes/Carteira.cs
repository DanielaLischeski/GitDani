using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantinaGG.Classes
{
    public class Carteira
    {
        double saldo = 0;

        public double Saldo { get { return saldo; } }

        public Carteira(double valor)
        {
            saldo = valor;
        }

        public bool PoderDeComprarLanches(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            return false;
        }

    }
}
