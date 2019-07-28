using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletimEscolarMelhorado.Classes
{
    public class Aluno
    {
        public string Nome { get; set; }

        public int Id { get; set; } = -1;

        public int TotalAulas { get; set; }

        public int TotalFaltas { get; set; }

        public double Nota1 { get; set; }

        public double Nota2 { get; set; }

        public double Nota3 { get; set; }

        public double CalcularMedia()
        {
            return (Nota1 + Nota2 + Nota3) / 3;
        }

        public int CalcularFrequencia()
        {
            return ((TotalAulas - TotalFaltas) * 100) / TotalAulas;
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
