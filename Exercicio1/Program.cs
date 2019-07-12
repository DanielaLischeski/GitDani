using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.WriteLine("<><>                                          <><>");
            Console.WriteLine("<><>             Você quer beber????          <><>");
            Console.WriteLine("<><>                                          <><>");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><>\r\n");

            Console.WriteLine("Então digite seu nome:");
            string nome = Console.ReadLine();

            //int.TryParse(Console.ReadLine(),)

            Console.WriteLine("\r\nE agora digite sua idade:");

            int.TryParse(Console.ReadLine(), out int idade);

            if(idade >= 18)
            {
                Console.WriteLine($"\r\nOba! {nome} você possui {idade} anos e é maior de idade, pode consumir bedida alcoólica! Mas se beber não dirija!");
            }
            else
            {
                Console.WriteLine($"\r\nQue pena {nome}! Você possui {idade} anos e é menor de idade. Beba água!");
            }

            Console.ReadKey();
        }
       
    }
}
