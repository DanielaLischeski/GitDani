using BibliotecaDeArquivosDoWindows; //pra adivionar a biblioteca pode digitar ou no código quando vai usar dar Ctrl+.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirsBibliotecaExterna
{
    class Program
    {
        static void Main(string[] args)
        {
            // var teste = new GetFiles(); (Felipe fez)
            // var arquivos = teste.RetornaArquivosDoMeuDocumentos();
            //é o mesmo que:

            GetFiles GF = new GetFiles(); //eu escolhi o nome de GF (Vilson fez) É o mesmo que: var GF = new GetFiles();
            string[] retorno = GF.RetornaArquivosDoMeuDocumentos();  //é o mesmo que: var retorno = GF.RetornaArquivosDoMeuDocumentos();

            Imprime(retorno);

            retorno = GF.RetornaArquivosGit();  //o Git retorna exceção, pois depende da atualização do dono da biblioteca (Felipe)

            Imprime(retorno);       
            
            retorno = GF.RetornaArquivosImagesFiles(); //também funciona se chamasse uma nova variável, mas assim é melho.
                                                       //string[] retorno 3 = GF.RetornaArquivosImagesFiles();
            Imprime(retorno);                       

            Console.ReadKey();
        }

        public static void Imprime(string[] texto)
        {
            for (int i = 0; i < texto.Length; i++)
            {
                Console.WriteLine(texto[i]);
            }
        }
    }
}
