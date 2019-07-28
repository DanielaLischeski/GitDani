using BoletimEscolar.Clases;
using BoletimEscolar.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizaBoletimEscolar
{
    class VisualizaResultado
    {        
        static void Main(string[] args)
        {
            Listagens cadastro = new Listagens();
                                   
            cadastro.FuncoesDoMenu();                   
                       
            Console.ReadKey();
        }
    }
}
