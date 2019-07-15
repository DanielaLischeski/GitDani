using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiDeManeiraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando nossa lista com mais de uma dimensão
            string[,] listaDeNome = new string[5, 2];

            //Usando um laço simples para colocar valores mas no mesmo utilizando o
            //GetLength com o parâmentro "0" para indicar que quermos o tamanho da primeira coluna
            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                //Carregando o que podemos chamar de ID, identificador do nosso registro único
                listaDeNome[i, 0] = i.ToString();
                //Aqui apenas adicionamos uma informação extra para deixar legal
                listaDeNome[i, 1] = $"Daniela_{i}";
            }

            //Lembrando que GetLength é um método e usamos "(parâmetro)" com parâmetro ou as vezes sem
            //para realizar a chamada mesmo
            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                //Formatamos uma string de maneira que os dados sejam apresentados
                Console.WriteLine($"ID:{listaDeNome[i,0]} - Nome:{listaDeNome[i,1]}");
            }
            Console.ReadKey();
        }
    }
}
