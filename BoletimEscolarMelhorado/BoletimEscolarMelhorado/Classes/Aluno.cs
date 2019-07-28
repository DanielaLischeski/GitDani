using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletimEscolarMelhorado.Classes
{
    public class Aluno
    {
        public string nome { get; set; }

        public int id { get; set; } = -1;

        public int totalAulas { get; set; }

        public int totalFaltas { get; set; }

        public double nota1 { get; set; }

        public double nota2 { get; set; }

        public double nota3 { get; set; }

        public double CalcularMedia()
        {
            return (nota1 + nota2 + nota3) / 3;
        }

        public int CalcularFrequencia()
        {
            return ((totalAulas - totalFaltas) * 100) / totalAulas;
        }

        public string SituacaoAluno()
        {
            if ((CalcularMedia() >= 7) && (CalcularFrequencia() >= 75))
                return "Aprovado";
            else
                return "Reprovado";
                
        }
    }
}
