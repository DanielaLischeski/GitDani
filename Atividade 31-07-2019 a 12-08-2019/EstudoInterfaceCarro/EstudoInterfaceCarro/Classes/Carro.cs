using EstudoInterfaceCarro.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoInterfaceCarro.Classes
{
    public class Carro : IIgual<Carro>
    {
        public Carro()
        {
            this.Fabricante = "Fábrica de Carros SA";
        }

        public Carro(string fabricante)
        {
            this.Fabricante = fabricante;
        }

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
