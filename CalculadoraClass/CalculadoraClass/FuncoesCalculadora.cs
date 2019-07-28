using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraClass
{
    public class FuncoesCalculadora
    {
        /// <summary>
        /// Método que realiza a soma de dois valores
        /// </summary>
        /// <param name="valor1"></param>
        /// <param name="valor2"></param>
        /// <returns></returns>
        public int CalculaAdicao(int valor1, int valor2)
        {
            return valor1 + valor2;
        }

        /// <summary>        
        ///método que realiza a subtação de dois valores
        /// </summary>
        /// <param name="valor1"></param>
        /// <param name="valor2"></param>
        /// <returns></returns>
        public int CalculaSubtracao(int valor1, int valor2)
        {
            return valor1 - valor2;
        }
        /// <summary>
        /// Método que multiplica dois valores
        /// </summary>
        /// <param name="valor1"></param>
        /// <param name="valor2"></param>
        /// <returns></returns>
        public int CalculaMultiplicacao(int valor1, int valor2)
        {
            return valor1 * valor2;
        }

        /// <summary>
        /// Método que divide dois valores 
        /// </summary>
        /// <param name="valor1"></param>
        /// <param name="valor2"></param>
        /// <returns></returns>
        public int CalculaDivisao(int valor1, int valor2)
        {
            return valor1 / valor2;
        }
        
        /// <summary>
        /// Método que calcula a área de um retânculo, com base em seus valores: base e altura
        /// </summary>
        /// <param name="valorBase">base do retângulo</param>
        /// <param name="valorAltura">altura do retângulo</param>
        /// <returns></returns>
        public int CalculaAreaRetangulo(int valorBase, int valorAltura)
        {
            return valorBase * valorAltura;
        }

        /// <summary>
        /// Método que calcula a área de um trigângulo equilátero, baseado no valor de seu lado.
        /// </summary>
        /// <param name="valorLado">3 lados iguais</param>
        /// <returns></returns>
        public double CalculaAreaTrianguloEquilatero(double valorLado)
        {
            return (valorLado * valorLado * Math.Sqrt(3))/4;
        }

        /// <summary>
        /// Método que calcula o raio de um círculo com base em sua área.
        /// </summary>
        /// <param name="areaCirculo">área do círculo</param>
        /// <returns></returns>
        public double CalculaRaioCirculo(double areaCirculo)
        {
            return Math.Sqrt(areaCirculo / Math.PI);
        }
    }
}
