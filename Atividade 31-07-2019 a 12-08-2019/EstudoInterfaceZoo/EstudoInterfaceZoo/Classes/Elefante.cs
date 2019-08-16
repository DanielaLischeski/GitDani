using EstudoInterfaceZoo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoInterfaceZoo.Classes
{
    public class Elefante : IAnimal
    {
        public string Nome { get; set; }

        public static int QuantasVezes { get; set; }

        // metodo statico, ou seja, ele é da classe, e não da instancia do momento
        public static void Fofinho()
        {
            QuantasVezes++;
            Console.WriteLine($"Já falei {QuantasVezes} vezes que elefantes são fofinhos");
        }
        
        public void Acordar()
        {
            Console.WriteLine($"{Nome} está acordado!");
        }

        public void Comer()
        {
            Console.WriteLine($"{Nome} está comendo.");
        }

        public void Dormir()
        {
            Console.WriteLine($"{Nome} foi dormir.");
        }

        public void UsarTromba()
        {
            Console.WriteLine($"{Nome} fez fuááááá");
        }
    }
}
