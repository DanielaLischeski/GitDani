using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCalculadora
{
    public class Calculadora
    {
        public int CalculaAdicao(int valor1, int valor2)
        {
            return valor1 + valor2;
        }
        public int CalculaSubtracao(int valor1, int valor2)
        {
            return valor1 - valor2;
        }
        public int CalculaMultiplicacao(int valor1, int valor2)
        {
            return valor1 * valor2;
        }
        public int CalculaDivisao(int valor1, int valor2)
        {
            return valor1 / valor2;
        }
    }
}
