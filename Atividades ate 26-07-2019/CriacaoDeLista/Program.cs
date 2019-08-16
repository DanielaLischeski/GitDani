using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CriacaoDeLista.Organizando.Lista;

namespace CriacaoDeLista
{
    class Program
    {
        static void Main(string[] args)
        {

            Listas l = new Listas();
            l.Carregalista();
            l.listar();

            l.LimparLista();
            l.listar();

        }
    }
}