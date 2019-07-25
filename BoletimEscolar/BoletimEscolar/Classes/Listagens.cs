using BoletimEscolar.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletimEscolar.Classes
{
    public class Listagens
    {
        string[,] arrayAluno = new string[2, 5];
        CalculaNotaFrequencia boletim = new CalculaNotaFrequencia();
        int pId;

        public void Inserir()
        {
            Cabecalho();

            for (int i = 0; i < arrayAluno.GetLength(0); i++)
            {
                Console.WriteLine("Informe o nome do aluno");
                var nome = Console.ReadLine();
                arrayAluno[i, 0] = i.ToString();
                arrayAluno[i, 1] = nome;

                var media = DigitaNotas();

                arrayAluno[i, 2] = media.ToString();

                //informações frequência
                Console.WriteLine("Informe o número de aulas:");
                int.TryParse(Console.ReadLine(), out int totalAulas);

                Console.WriteLine("Informe o número de faltas:");
                int.TryParse(Console.ReadLine(), out int numeroFaltas);
                var frequencia = boletim.CalculoDeFrequencia(totalAulas, numeroFaltas);

                arrayAluno[i, 3] = frequencia.ToString();

                //informa situação
                arrayAluno[i, 4] = boletim.retornaSituacaoAluno(media, frequencia);

            }

            ListarInformacoes();
        }

        public int DigitaNotas()
        {
            Console.WriteLine("Informe a nota 1:");
            int.TryParse(Console.ReadLine(), out int nota1);

            Console.WriteLine("Informe a nota 2:");
            int.TryParse(Console.ReadLine(), out int nota2);

            Console.WriteLine("Informe a nota 3:");
            int.TryParse(Console.ReadLine(), out int nota3);

            return boletim.CalculoDeMedia(nota1, nota2, nota3);

        }
        public void ListarInformacoes()
        {
            Cabecalho();

            for (int i = 0; i < arrayAluno.GetLength(0); i++)
            {
                Console.WriteLine($"Id..........: {arrayAluno[i, 0]}");
                Console.WriteLine($"Aluno.......: {arrayAluno[i, 1]}");
                Console.WriteLine($"Média.......: {arrayAluno[i, 2]}");
                Console.WriteLine($"Frequência..: {arrayAluno[i, 3]}%");
                Console.WriteLine($"Situação....: {arrayAluno[i, 4]}\n");
            }

            Console.WriteLine("Digite qualquer tecla para continuar.");
        }


        public void ApagaRegistro()
        {
            Cabecalho();

            Console.WriteLine("\r\nInforme o Id do aluno para remover um registro: ");
            var capturaNome = Console.ReadLine();

            for (int i = 0; i < arrayAluno.GetLength(0); i++)
            {

                if (capturaNome == arrayAluno[i, 0])
                {
                    arrayAluno[i, 1] = "";
                    arrayAluno[i, 2] = "";
                    arrayAluno[i, 3] = "";
                    arrayAluno[i, 4] = "";

                    Console.WriteLine("Deseja remover o registro? sim(s) ou não (n)");
                    var continuar = Console.ReadLine().ToString().ToLower();

                    if (continuar == "s")
                        break;
                }

            }

            ListarInformacoes();

        }

        public void AlteraRegistro(int pId)
        {
            for (int i = 0; i < arrayAluno.GetLength(0); i++)
            {
                if (arrayAluno[i, 0] == pId.ToString())
                {
                    var media = DigitaNotas();
                    arrayAluno[i, 2] = media.ToString();
                    var frequencia = Convert.ToInt32(arrayAluno[i, 3]);
                    arrayAluno[i, 4] = boletim.retornaSituacaoAluno(media, frequencia);
                    break;
                }
            }
        }

        // public void AlterarRegistro(int pId)
        // {
        //     Cabecalho();
        //
        //     Console.WriteLine("\r\nInforme o Id do aluno para alterar uma informação: ");
        //     var capturaNome = Console.ReadLine();
        //
        //     for (int i = 0; i < arrayAluno.GetLength(0); i++)
        //     {
        //
        //         if (arrayAluno[i, 0] == pId.ToString())
        //         {
        //             var media = boletim.CalculoDeMedia(nota1, nota2, nota3);
        //             arrayAluno[i, 2] = media.ToString(); 
        //             arrayAluno[i, 3] = "";
        //             arrayAluno[i, 4] = "";
        //
        //             Console.WriteLine("Deseja remover o registro? sim(s) ou não (n)");
        //             var continuar = Console.ReadLine().ToString().ToLower();
        //
        //             if (continuar == "s")
        //                 break;
        //         }
        //
        //     }
        //
        //
        // }
        //
        public void Cabecalho()
        {
            

            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.WriteLine("<><>                                          <><>");
            Console.WriteLine("<><>          Boletim de alunos OnLine        <><>");
            Console.WriteLine("<><>                                          <><>");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><>");
        }

        public int Menu()
        {
            Cabecalho();

            Console.WriteLine($"Menu principal ---- o que você deseja fazer?" +
                              $"\n1 - Mostrar boletim " +
                              $"\n2 - Inserir notas " +
                              $"\n3 - Altera notas " +
                              $"\n4 - Apaga registro " +
                              $"\n5 - Sai do sistema ");

            Console.WriteLine("\r\nDigite o número desejado:");
            return Convert.ToInt32(Console.ReadLine());

        }

        public void FuncoesDoMenu()
        {
            while (true)
            {


                switch (Menu())
                {
                    case 1: { ListarInformacoes(); break; }

                    case 2: { Inserir(); break; }

                    case 3: { AlteraRegistro(pId); break; }

                    case 4: { ApagaRegistro(); break; }

                    case 5:
                        {
                            return;
                        }

                }

            }
        }

    }
}
