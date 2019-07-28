using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "João";

            MudaNome(nome);

            Console.WriteLine(nome);

            Console.ReadKey();

        }

        public static void MudaNome(string nome)
        {
            nome = "Zeca";
        }
    }
}



