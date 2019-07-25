using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletimEscolar.Clases
{
    public class CalculaNotaFrequencia
    {
        
        public int CalculoDeMedia(int nota1, int nota2, int nota3)
        {
            return (nota1 + nota2 + nota3) / 3;         
        }

        public int CalculoDeFrequencia(int totalAulas, int numeroFaltas)
        {
           return ((totalAulas - numeroFaltas) * 100)/totalAulas;   
        }

        public void SituacaoAluno(int media, int frequencia)
        {
            if ((media >= 7) && (frequencia >= 75))
                Console.WriteLine($"Aluno apovado com média {media} e frequêcia {frequencia}%");
            else
                Console.WriteLine($"Aluno reprovado com média {media} e frequência {frequencia}%");
        }

        public string retornaSituacaoAluno(int media, int frequencia)
        {
            if ((media >= 7) && (frequencia >= 75))
                return "Aprovado";
            else
                return "Reprovado";
        }
    }
}
