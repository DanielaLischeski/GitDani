using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.WriteLine("<><>                                          <><>");
            Console.WriteLine("<><>               BOLO MAJESTOSO             <><>");
            Console.WriteLine("<><>                                          <><>");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><>");

            Console.ReadKey();

            ListaIngredientes();

            ModoDePreparo();

            Console.WriteLine("\r\n\r\nBOM APETITE!");
            Console.ReadKey();
        }

        public static void ListaIngredientes()
        {
            Console.WriteLine("\r\nLISTA DE INGREDIENTES:\r\n");

            string[] ingredientes = new string[7]
                {"3 xícaras (chá) de farinha de trigo",
                    "1 colher (sopa) de fermento em pó",
                    "1 xícara (chá) de manteiga",
                    "2 xícaras (chá) de açúcar",
                    "1 xícara (chá) de leite",
                    "4 ovos",
                    "100 g de chocolate em pó\r\n"};


            for (int i = 0; i < ingredientes.Length; i++)
                Console.WriteLine(ingredientes[i]);

            Console.ReadKey();
        }

        public static void ModoDePreparo()
        {
            Console.WriteLine("\r\nMODO DE PREPARO:\r\n");

            string[] modoPreparo = new string[6]
                {"1 - Bata bem na batedeira a manteiga com açúcar e as gemas até ficarem leves e claras.\r\n",
                "2 - A seguir acrescente o leite e a farinha de trigo.\r\n",
                "3 - Separadamente, bata as claras em neve.\r\n",
                "4 - Acrescente as claras batidas à massa. Coloque o fermento em pó e misture sem bater.\r\n",
                "5 - Divida a massa em 2 partes, coloque chocolate em uma das partes e misture.\r\n",
                "6 - Em uma forma untada e esfarinhada, coloque as duas massas e Asse em forno médio, pré-aquecido, por cerca de 40 minutos, ou até dourar."};


            for (int i = 0; i < modoPreparo.Length; i++)
            {
                Console.WriteLine(modoPreparo[i]);
                Console.ReadKey();
            }
        }
    }
}
