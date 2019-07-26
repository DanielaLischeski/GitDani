using Calculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessandoDLLMarlon
{
    class Program
    {
        static void Main(string[] args)
        {
            var usandoCaluladoraMarlon = new Operador();

            Console.WriteLine($"Soma: {usandoCaluladoraMarlon.Adicao(20.2,22)}");

            Console.WriteLine($"Divisao: {usandoCaluladoraMarlon.Divisao(50,25)}");

            Console.WriteLine($"Multiplicacao: {usandoCaluladoraMarlon.Multiplicacao(1.5, 4)}");

            Console.WriteLine($"Raio do circulo: {usandoCaluladoraMarlon.RaioDoCirculo(65)}");

            Console.WriteLine($"Retangulo: {usandoCaluladoraMarlon.Retangulo(2.5,8)}");

            Console.WriteLine($"Subtração: {usandoCaluladoraMarlon.Subtracao(26,32)}");

            Console.WriteLine($"Triangulo: {usandoCaluladoraMarlon.TrianguloEquilatero(7)}");

            Console.ReadKey();
         
        }
    }
}
