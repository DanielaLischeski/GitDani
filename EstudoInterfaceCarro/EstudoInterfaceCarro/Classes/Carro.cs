using EstudoInterfaceCarro.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoInterfaceCarro.Classes
{
    public class Carro : IIgual<Carro>
    {
        public string Fabricante { get; set; }
        public string Ano { get; set; }
        public string Modelo { get; set; }

        public bool Comparar(Carro carro)
        {
            return this.Fabricante == carro.Fabricante &&
                   this.Ano == carro.Ano &&
                   this.Modelo == carro.Modelo;
        }
    }
}
