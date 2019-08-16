using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCSharp.Classes
{
    public class Conta
    {
        double saldo = 0;

        //Propriedade que contem o valor do saldo
        public double Saldo { get { return saldo; } }
        public Conta() //método construtor
        {
            //Bonus de mil reis pra iniciar operar daytrade
            saldo = 1000;
        }

        /// <summary>
        /// Método para sacar de acordo com o saldo disponível
        /// </summary>
        /// <param name="valor">valor para sacar</param>
        /// <returns>retorna se o saque foi feito ou não</returns>returns>
        public bool Sacar(double valor)
        {
            if(valor <= saldo)
            {
                //Desconta do valor em saldo na conta
                saldo -= valor;
                return true;
            }
            //Retorna false em caso de não conter saldo disponível
            return false;
                     
        }
        /// <summary>
        /// Método para kostrar o saldo em conta disponível
        /// </summary>
        public double MostrarSaldo()
        {
            return saldo;
        }
    }
}
