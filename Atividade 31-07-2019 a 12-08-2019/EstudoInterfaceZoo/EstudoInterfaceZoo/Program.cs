using EstudoInterfaceZoo.Classes;
using EstudoInterfaceZoo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoInterfaceZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Lobo cinzento = new Lobo();
            Lobo guara = new Lobo();

            Elefante asiatico = new Elefante();
            Elefante africano = new Elefante();

            Zoologico zooPomerode = new Zoologico();

            Elefante.Fofinho();
            Elefante.Fofinho();
            Elefante.Fofinho();
            Elefante.Fofinho();

            
            cinzento.Nome = "Lobo Cinzento";
            guara.Nome = "Lobo Guará";

            cinzento.Acordar();
            guara.Dormir();

            zooPomerode.animal1 = asiatico;

            asiatico.Nome = "Elefante asiático";
            africano.Nome = "Elefante africano";

            zooPomerode.animal1.Comer();

            africano.UsarTromba();

            Tratar(africano);

            Tratar(cinzento);



            Console.ReadKey();
        }


        public static void Tratar(IAnimal animal) //exemplo de inversão de controle: não depente da classe e sim da interface, ela aceita todas as classes que implementaram a Interface IAnimal
        {                                         //na inversão de controle é usada uma Interface como Parâmetro
            animal.Comer();
        }
    }
}
