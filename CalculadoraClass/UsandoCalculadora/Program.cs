using CalculadoraClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            FuncoesCalculadora bbCalc = new FuncoesCalculadora();
            //é o mesmo que:
            //var bbCalc = new FuncoesCalculadora();

            Console.WriteLine($"Soma = {bbCalc.CalculaAdicao(5, 5)}");

            Console.WriteLine($"Subtração = {bbCalc.CalculaSubtracao(12, 5)}");

            Console.WriteLine($"Multiplicação = {bbCalc.CalculaMultiplicacao(2, 4)}");

            Console.WriteLine($"Divisao = {bbCalc.CalculaDivisao(10, 5)}");

            Console.WriteLine($"Calcula área de retângulo = {bbCalc.CalculaAreaRetangulo(2,4)}");

            Console.WriteLine($"Calcula área de triângulo equilátero = {bbCalc.CalculaAreaTrianguloEquilatero(5)}");

            Console.WriteLine($"Calcula raio de círculo = {bbCalc.CalculaRaioCirculo(12)}");

            Console.ReadKey();
        }
    }
}
