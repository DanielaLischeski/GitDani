using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoDeLista.Organizando.Lista
{
    public class Listas
    {
        string[] lista;


        public Listas()
        {
            lista = new string[20];
            Carregalista();
        }

        public void Carregalista()
        {
            for (int i = 0; i < lista.Length; i++)
            {
                lista[i] = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff");

            }
        }
        public void LimparLista()
        {

            for (int i = 0; i < lista.Length; i++)
                lista[i] = string.Empty;
        }

        public void listar()
        {
            foreach (var item in lista)

                Console.WriteLine(item);

            Console.ReadKey();
        }


    }

}
