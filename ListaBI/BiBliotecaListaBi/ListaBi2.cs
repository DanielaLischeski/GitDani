using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiSuperCompacta.BibliotecaListaBi
{
    class ListaBI
    {
        string[,] listaBi;
        /// <summary>
        /// INICIAMOS nossa lista Bi, agora quando iniciamos uma istancia dela ela ja
        /// vem com a lista carregada.
        /// </summary>
        public ListaBI()
        {
            listaBi = new string[5, 2];
            //Ao chamar este metodo no construtor nossa lista ja vai estar carregada
            //Ao iniciar a instancia "jogar para memoria"
            CarregaListaBi();
        }
        /// <summary>
        /// Aqui ja carregamos "popular" a alista quando chamado este metodo.
        /// </summary>
        public void CarregaListaBi()
        {
            for (int i = 0; i < listaBi.GetLength(0); i++)
            {
                listaBi[i, 0] = i.ToString();
                listaBi[i, 1] = $"Felipe_{i}";

                Console.WriteLine($"Id:{i} Nome:Felipe_{i}");

            }

        }
        /// <summary>
        /// Aquui temos o metodo que realiza a pesquisa das informacoes em nossa lista
        /// </summary>
        /// <param name="idPesquisa"></param>
        public void PesquisaLista(string idPesquisa)
        {
            for (int i = 0; i < listaBi.GetLength(0); i++)
            {
                if (listaBi[i, 0] == idPesquisa)
                {
                    Console.WriteLine("Resultado encontrado com sucesso!");
                    Console.WriteLine($"Você pesquisou pelo registro:{ listaBi[i, 1]}");
                    //Saio do metodo porque nao preciso mais dele sem passar nada porque ele e um void "Vazio,sem tipo"

                    return;
                }
            }

            Console.WriteLine("Nenhum registro encontrado com esse Id");
        }

    }
}