using EstudoInterfaceCarro.Classes;
using System;

namespace EstudoInterfaceCarro
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro uno = new Carro("Fiat");
            Carro agile = new Carro();

            Console.WriteLine($"Fabricante padrão Uno: {uno.Fabricante}");

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
