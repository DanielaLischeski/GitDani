using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_______________________________\r\n");
            Console.WriteLine("      LISTAGEM DE ALUNOS");
            Console.WriteLine("      nome | idade | sexo\r\n");
            Console.WriteLine("_______________________________\r\n\r\n");

            Console.ReadKey();

            string[,] listaAlunos = new string[20, 3]
               {{"Amanda","18","feminino" }, {"Antônio","21","masculino" }, {"Carlos","19","masculino" }, {"Dionei","20","masculino" },
               {"Elisa","22","feminino" }, {"Fernando","23","masculino" }, {"Fabiana","19","feminino" }, {"Gabriel","18","masculino" },
               {"Heitor","21","masculino" }, {"Ivone","20","feminino" }, {"João","17","masculino" }, {"Larissa","22","feminino" },
               {"Maria","24","feminino" }, {"Miran","21","feminino" }, {"Nelson","19","masculino" }, {"Pedro","23","masculino" },
               {"Renan","18","masculino" }, {"Rafaela","20","feminino" }, {"Thomas","18","masculino" }, {"Vanessa","23","feminino" } };

            for (int i = 0; i < listaAlunos.GetLength(0); i++)
            {
                var nomeAluno = listaAlunos[i, 0];
                var idadeAluno = listaAlunos[i, 1];
                var sexoAluno = listaAlunos[i, 2];

                Console.WriteLine($"Aluno: {nomeAluno} | Idade: {idadeAluno} | Sexo: {sexoAluno}");
            }

            Console.ReadKey();
        }
    }
}
