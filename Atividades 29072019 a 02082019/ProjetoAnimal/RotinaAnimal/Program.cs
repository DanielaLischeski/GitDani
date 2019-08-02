using ProjetoAnimal.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotinaAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal monitoraAnimal = new Animal();
            //é o memso que: var monitoraAnimal = new Animal();

            monitoraAnimal.Nome = "Elefante";

            Console.WriteLine($"{monitoraAnimal.Nome} {monitoraAnimal.Acordar()}");

            Console.WriteLine($"{monitoraAnimal.Nome} {monitoraAnimal.Comer()}");

            Console.WriteLine($"{monitoraAnimal.Nome} {monitoraAnimal.Dormir()}");

            Rotina monitoraRotina = new Rotina();

            monitoraRotina.Nome = "Lebre";

            monitoraRotina.Idade = 2;

            Console.WriteLine($"{monitoraRotina.Nome} possui {monitoraRotina.Idade} anos");

            Console.WriteLine($"{monitoraRotina.Nome} {monitoraRotina.Acordar()}");

            Console.WriteLine($"{monitoraRotina.Nome} {monitoraRotina.Comer()}");

            Console.WriteLine($"{monitoraRotina.Nome} {monitoraRotina.Dormir()}");

            Console.ReadKey();
        }
    }
}
