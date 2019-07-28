using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletimEscolarMelhorado.Classes
{
    public class MostraInformacoes
    {
        Aluno[] alunos = new Aluno[2];
        int id = 0;

        public void Informacoes()
        {
            InicializarAlunos();

            while (true)
            {
                switch(Menu())
                {
                    case 1: { InserirRegistros(); break;}
                    case 2: { MostrarBoletim(); break; }
                    case 3: { AlterarRegistro(); break; }
                    case 4: { ApagarRegistro(); break; }
                    case 5: { return; }
                }
            }

            Console.ReadKey();
        }

        public void Cabecalho()
        {


            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.WriteLine("<><>                                          <><>");
            Console.WriteLine("<><>          Boletim de alunos OnLine        <><>");
            Console.WriteLine("<><>                                          <><>");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><>\r\n");
        }

        public int Menu()
        {
            Cabecalho();

            Console.WriteLine($"---------Menu principal---------" +
                              $"\nO que você deseja fazer?" +
                              $"\n1 - Inserir registros " +
                              $"\n2 - Mostrar boletim " +
                              $"\n3 - Alterar registros " +
                              $"\n4 - Apagar registros " +
                              $"\n5 - Sair do sistema ");

            Console.WriteLine("\r\nDigite o número desejado:");
            return Convert.ToInt32(Console.ReadLine());

        }

        public Aluno RegistraInformacoes(Aluno informacoes)
        {
            Console.WriteLine("Informe o nome do aluno");
            informacoes.nome = Console.ReadLine();

            Console.WriteLine("Informe a nota 1:");
            int.TryParse(Console.ReadLine(), out int notaInserida1);
            informacoes.nota1 = notaInserida1;

            Console.WriteLine("Informe a nota 2:");
            int.TryParse(Console.ReadLine(), out int notaInserida2);
            informacoes.nota2 = notaInserida2;

            Console.WriteLine("Informe a nota 3:");
            int.TryParse(Console.ReadLine(), out int notaInserida3);
            informacoes.nota3 = notaInserida3;

            Console.WriteLine("Informe o número de aulas:");
            int.TryParse(Console.ReadLine(), out int totalAulasInserida);
            informacoes.totalAulas = totalAulasInserida;

            Console.WriteLine("Informe o número de faltas:");
            int.TryParse(Console.ReadLine(), out int totalFaltasInserida);
            informacoes.totalFaltas = totalFaltasInserida;

            return informacoes;
        }

        public void InserirRegistros()
        {
            for (int i = 0; i < alunos.GetLength(0); i++)
            {
                if(alunos[i].id < 0)
                {
                    Aluno informacoesAluno = new Aluno();

                    informacoesAluno = RegistraInformacoes(informacoesAluno);

                    informacoesAluno.id = id;
                    id++;

                    alunos[i] = informacoesAluno;

                    Console.WriteLine("\r\n");
                }
 
            }

            Console.Clear();
        }

        public void MostrarBoletim()
        {
            Cabecalho();

            for (int i = 0; i < alunos.GetLength(0); i++)
            {
                if (alunos[i].id >= 0)
                {
                    Console.WriteLine($"Id..........: {alunos[i].id}");
                    Console.WriteLine($"Aluno.......: {alunos[i].nome}");
                    Console.WriteLine($"Média.......: {alunos[i].CalcularMedia()}");
                    Console.WriteLine($"Frequência..: {alunos[i].CalcularFrequencia()}%");
                    Console.WriteLine($"Situação....: {alunos[i].SituacaoAluno()}\n");
                }
            }

            Console.WriteLine("Digite qualquer tecla para continuar.");
        }

        public void AlterarRegistro()
        {
            Console.WriteLine($"Digite o Id para alterar registro: ");
            int.TryParse(Console.ReadLine(), out int idBusca);

            for (int i = 0; i < alunos.GetLength(0); i++)
            {
                if(alunos[i].id == idBusca)
                {
                    alunos[i] = RegistraInformacoes(alunos[i]);
                }
            }
        }

        public void ApagarRegistro()
        {
            Console.WriteLine($"Digite o Id para apagar registro: ");
            int.TryParse(Console.ReadLine(), out int idBusca);

            for (int i = 0; i < alunos.GetLength(0); i++)
            {
                if (alunos[i].id == idBusca)
                {
                    alunos[i] = new Aluno();
                }
            }
        }

        public void InicializarAlunos()
        {
            for (int i = 0; i < alunos.GetLength(0); i++)
            {
                alunos[i] = new Aluno();
            }
        }
    }
}
