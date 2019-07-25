using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletimEscolar.Classes
{
    public class Listagens
    {
        public void ListaInformacoes(string nome, int notas, int freq)
        {
            string[,] listaDeAlunos = new string[5, 4];

            int IdParaLista = 0;


            for (int i = 0; i < listaDeAlunos.GetLength(0); i++)
            {
                if (listaDeAlunos[i, 0] != null)
                    continue;

                Console.WriteLine("\r\nInforma o nome do aluno para adicionar um registro:");
                var nomeAluno = Console.ReadLine();

                Console.WriteLine("\r\nInforma a nota do aluno para adicionar um registro:");
                var nota = Console.ReadLine();

                Console.WriteLine("\r\nInforma o número de faltas do aluno para adicionar um registro:");
                var faltas = Console.ReadLine();

                listaDeAlunos[i, 0] = (IdParaLista++).ToString();
                listaDeAlunos[i, 1] = nomeAluno;
                listaDeAlunos[i, 2] = nota;
                listaDeAlunos[i, 3] = faltas;

                Console.WriteLine("\r\nDeseja inserir um novo registro? sim(1) ou não(0)");

                var continuar = Console.ReadKey().KeyChar.ToString();

                if (continuar == "0")
                    break;
            }

        }
    }
}