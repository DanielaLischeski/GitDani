using EstudoInterfaceCarro.Classes;
using System;

namespace EstudoInterfaceCarro
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro uno = new Carro();
            Carro agile = new Carro();

            uno.Fabricante = "Fiat";
            uno.Ano = "1991";
            uno.Modelo = "Uno";

            agile.Fabricante = "Chevrolet";
            agile.Ano = "2011";
            agile.Modelo = "Agile";

            if(uno.Comparar(agile))
                Console.WriteLine("São iguais");
            else
                Console.WriteLine("Não são iguais");

            Console.ReadKey();
        }
    }
}
