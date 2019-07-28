﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAnimal.Classes
{
    public class Animal
    {
        public string Nome; //propriedade Nome, é uma variável global da classe
        public string Acordar()
        {
            return "acordou";
        }
        public string Comer()
        {
            return "está comendo";
        }
        public string Dormir()
        {
           return "está dormindo";
        }
    }
}
