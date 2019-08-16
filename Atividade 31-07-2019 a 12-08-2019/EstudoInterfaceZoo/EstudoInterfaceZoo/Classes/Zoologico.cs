using EstudoInterfaceZoo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoInterfaceZoo.Classes
{
    public class Zoologico 
    {
        public IAnimal animal1 { get; set; }//inversão de controle, pois esta propriedade aceita qualquer classe que tenha a Interface IAnimal
    }
}
