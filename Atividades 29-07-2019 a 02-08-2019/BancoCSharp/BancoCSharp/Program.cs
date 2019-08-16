using BancoCSharp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta accountUser = new Conta();

            Console.WriteLine("Informe o valor para saque:");

            //Aqui usamos a conversão do valor informado
            double.TryParse(Console.ReadLine(), out double valorSacar);

            //Verificamos se o valor é maior que 0 e se realizou o saque
            if (valorSacar > 0 && accountUser.Sacar(valorSacar))
                Console.WriteLine("Saque realizado com sucesso!");
            else
                Console.WriteLine("Operação não realizada");

            //Mostramos o saldo disponível
            Console.WriteLine($"Saldo atual disponível:{accountUser.Saldo.ToString("N2")}"); //N2 mostra 2 casas após a vírgula

            Console.ReadKey();
        }
    }
}
