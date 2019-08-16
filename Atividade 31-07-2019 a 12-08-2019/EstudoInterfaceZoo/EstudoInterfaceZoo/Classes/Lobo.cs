using EstudoInterfaceZoo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoInterfaceZoo.Classes
{
    public class Lobo : IAnimal //implementando a Interface IAnimal, se houver outras interfaces pode implementar, é só separar por vírgula
    {
        public string Nome { get; set; }

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


    }
}
