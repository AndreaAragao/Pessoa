using System;
using System.Collections.Generic;
using System.Text;
using Testes016.Util;

namespace Testes016.Entity
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public Genero Genero { get; set; }

        public override string ToString()
        {
            return Nome + " " + Idade + " anos " + Genero;
        }
    }
}
