using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoDeLista
{
    class Program
    {
        static void Main(string[] args)
        {
            //Iniciando uma lsita de string com array linear
            string[] lista = new string[10]; //aqui definimos as posições da lista iniciandp ela com 10
            //espaços na memória para alocar informações de texto

            //laço que usamos geralmente para andar sobre as posições da noss alista
            for (int i = 0; i < lista.Length; i++)
            {
                //caregando os valores da nossa lsita aqui
                //onde "i" representa cada espaço que temos disponível
                lista[i] = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff");
                //DateTime é um tipo do .net c# que diponibiliza funções relacionadas a datas
                //e horas, ou seja, se precisar trabalhar com essas informações é possíveç ussa este cara.
            }

            //Laço de repetição que usamos para varrer nossa lista de maneira mais simples
            foreach (var item in lista) //"var item" idica uma unidade da nossa lista "in lista"
                //indica a lista que desejamos varrer
                Console.WriteLine(item); //Aqui apresentamos essa informação na tela.

            Console.ReadKey();

        }
    }
}
