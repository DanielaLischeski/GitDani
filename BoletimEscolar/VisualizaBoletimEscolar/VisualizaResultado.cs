using BoletimEscolar.Clases;
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
            CalculaMedia boletim = new CalculaMedia();

            Console.WriteLine("Insira a primeira nota do alunos: ");
            var n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira a segunda nota do alunos: ");
            var n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira a terceira nota do alunos: ");
            var n3 = Convert.ToInt32(Console.ReadLine());

            var media = boletim.CalculoDeMedia(n1, n2, n3);
                             
            Console.WriteLine("Insira o número total de aulas: ");
            var aulas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o número de faltas do aluno: ");
            var faltas = Convert.ToInt32(Console.ReadLine());
            var frequencia = boletim.CalculoDeFrequencia(aulas, faltas);

            boletim.SituacaoAluno(media, frequencia);

            Console.ReadKey();
        }
    }
}
