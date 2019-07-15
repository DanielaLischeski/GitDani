using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertAndRemoveInList
{
    class Program
    {
        static void Main(string[] args)
        {
            //criamos a nossa base de dados inicial
            string[,] baseDeDados = new string[2, 3];

            //indicador dos registros realizados em nosso sistema
            int IndiceBaseDeDados = 0;

            //Apresentação inicial do nosso sistema
            Console.WriteLine("Iniciando sistema de lista de nome e idade.");
            //Criamos a variável fora para não ser criada novamente
            var escolhaInicial = ApresentaMenuInicial();

            //Loop infinito até que de uma treta
            while (true)
            {
                //Iniciando a escolha do nosso menu
                switch (escolhaInicial)
                {
                    //1 - Insere as informações 
                    case "1": { InsereValoresNaLista(ref baseDeDados, ref IndiceBaseDeDados); } break;
                    //2 - Remove informações da nossa lista
                    case "2": { RemoverInformacoes(ref baseDeDados); } break;
                    //3 - Lista as informações da lista
                    case "3": { MostrarInformacoes(baseDeDados); } break;
                    //4 - Sai do nosso sistema
                    case "4":
                        {
                            //Return dentro do nosso caso de escolha ele sai do nosso metodo principal ou
                            //método que estamos dentro de contexto
                            return;
                        }

                }
                //Alimento a escolha novamente
                escolhaInicial = ApresentaMenuInicial();
            }
        }

        /// <summary>
        /// Apresenta as informações do menu inicial.
        /// </summary>
        /// <returns>Retorna o menu escolhido.</returns>
        public static string ApresentaMenuInicial()
        {
            //Estrou no menu inicial inicializa a limpeza da tela
            Console.Clear();
            Console.WriteLine("Menu");
            Console.WriteLine("1 - Inserir um novo registro.");
            Console.WriteLine("2 - Remover um novo registro.");
            Console.WriteLine("3 - Listar informações");
            Console.WriteLine("4 - Sair do sistema");

            Console.WriteLine("Digite o número da opção desejada");
            //retorna diretamente o menu escolhido.
            return Console.ReadLine();
        }

        /// <summary>
        /// Método que insere informações dentro da nossa base de dados
        /// </summary>
        /// <param name="baseDeDados">Base de dados como ref para alterar para todos os métodos</param>
        /// <param name="indiceBase">Índice da nossa base com ref para alterar para todos os métodos</param>
        public static void InsereValoresNaLista(ref string[,] baseDeDados, ref int indiceBase)
        {
            Console.WriteLine("---------Inserindo valores da lista----------");

            Console.WriteLine("Informe um nome:");
            //Pegamos a informação digitada pelo usuário, aqui neste elemento esperamos o nome da pessoa
            var nome = Console.ReadLine();

            //Aumenta o tamanho da lita quando chegou no limite
            AumentaTamanhoLista(ref baseDeDados);

            Console.WriteLine("Informe a idade:");
            //Aqui pegamos a idade da pessoa digitada pelo usuário do sistema
            var idade = Console.ReadLine();

            //Iniciamos o laço de repetição para varrer nossa base de dados
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 0] != null)
                    continue;

                //Indentificamos de maneira única nosso registro "(" e ")" garante que ele incremente primeiro
                //antes de fazer a conversão para string
                baseDeDados[i, 0] = (indiceBase++).ToString();
                //Carregamos na segunda coluna o valor nome
                baseDeDados[i, 1] = nome;
                //carregamos na terceira coluna o valor idade
                baseDeDados[i, 2] = idade;

                //Finalizamos aqui para apenas inserir um registro por vez
                break;
            }
            //Informamos para o usuário que finalizaou o registro e agora o mesmo irá voltar para o menu inicial
            Console.WriteLine("Registro cadastrado com sucesso!");
            Console.WriteLine("Para voltar ao menu inicial, basta apertar qualquer tecla.");
            Console.ReadKey();

        }

        /// <summary>
        /// Mostra as informações dentro da nossa lista de dados "base de dados"
        /// </summary>
        /// <param name="baseDeDados">base de dados para a leitura e mostrar pro usuário</param>
        public static void MostrarInformacoes(string[,] baseDeDados)
        {
            //informamos em que tela o memo está
            Console.WriteLine("Apresentação das informações dentro da base de dados.");
            //Laço simples aonde o mesmo mostra de maneira formatada as informações
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
                Console.WriteLine($"ID {baseDeDados[i, 0]} " +
                    $" - Nome: {baseDeDados[i, 1]}" +
                    $" - Idade: {baseDeDados[i, 2]}");

            //FInalizamos a operação e indicamos que não existe mais operações a serem realizadas em
            //nosso método.
            Console.WriteLine("Resultados apresentados com sucesso!");
            Console.WriteLine("Para voltar ao menu inicial informar qualquer tecla.");
            Console.ReadKey();
        }

        /// <summary>
        /// Método utilizado para remover um registro pelo id dentro do sistema
        /// </summary>
        /// <param name="baseDeDados">Base de dados em que ele irá remover o registro pelo id</param>
        public static void RemoverInformacoes(ref string[,] baseDeDados)
        {
            //Identificamos a tela do menu que o usuário está
            Console.WriteLine("Área de remoção de registro do sistema.");
            //Laço de repetição que mostra informações dentro da tela de exclusão para facilitar a
            //escolha do id corretamente
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
                Console.WriteLine($"ID: {baseDeDados[i, 0]}" +
                    $" - Nome: {baseDeDados[i, 1]}" +
                    $" - Idade: {baseDeDados[i, 2]}");

            //Indicamos para o usuário informar um id dentro do nosso sistema para remover
            Console.WriteLine("Informe o id do registro a se removido:");
            var id = Console.ReadLine();

            //outro laço agora para remover o registro caso o mesmo exista
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                //Aqui comparamos os registros para validar o ig
                //Colocamos "&&" pois a comparação de um valor string com um valor null
                //pode gerar erro.
                if (baseDeDados[i, 0] != null && baseDeDados[i, 0] == id)
                {
                    //Nesta parte limpamos o registro de nossa base de dados
                    baseDeDados[i, 0] = null;
                    baseDeDados[i, 1] = null;
                    baseDeDados[i, 2] = null;
                }

            }
            //Finalizamos as operações desta tela
            Console.WriteLine("Operações finalizadas.");
            Console.WriteLine("Para retornar ao menu iniciaç apertar qualquer tecla.");
            Console.ReadKey();
        }

        /// <summary>
        /// Método que aumenta as informações disponíveis para cadastro dentro da nossa lista        ///
        /// </summary>
        /// <param name="baseDeDados">Retorna nossa base de dados</param>
        public static void AumentaTamanhoLista(ref string[,] baseDeDados)
        {
            //Verifica se precisa criar uma lista maior
            var limiteDaLista = true;
            //Laço que verifica se existe registro disponível
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                //Caso ainda existir registro disponível ele seta nossa variável "limiteDaLista" para false
                if (baseDeDados[i, 0] == null)
                    limiteDaLista = false;
            }

            //Caso não tenha mais registro nossa variável ficou como true entrão indica que precisamos aumentar nossa lista
            if (limiteDaLista)
            {
                //criamos uma cópia da nossa lista para não perder os valores
                var listaCopia = baseDeDados;
                //Aqui limpamos nossa lista antiga e assinamos novamente com uma lista com mais espaços
                baseDeDados = new string[baseDeDados.GetLength(0) + 5, 3]; //sempre vai aumentar 5 registros
                //Agora copiamos os registros da nossa lista antiga e passamos para a nossa nova lista
                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    //Copiamos a informação do identificador único
                    baseDeDados[i, 0] = listaCopia[i, 0];
                    //Copiamos a informação do nosso nome
                    baseDeDados[i, 1] = listaCopia[i, 1];
                    //A informação da idade foi atualizada
                    baseDeDados[i, 2] = listaCopia[i, 2];
                }
                //indicamos que neste ponto a lista foi atualizada em seu tamanho.
                Console.WriteLine("O tamanho da lista foi atualizado.");
            }
        }
    }
}
