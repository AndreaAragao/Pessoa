using System;
using Testes016.Entity;

namespace Testes016
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pessoa andrea = new Pessoa();
            andrea.Nome = "Andréa";
            andrea.Idade = 27;
            andrea.Genero = Util.Genero.Feminino;

            Pessoa douglas = new Pessoa();
            douglas.Nome = "Douglas";
            douglas.Idade = 34;
            douglas.Genero = Util.Genero.Masculino;

            Console.WriteLine(andrea.Nome + " " 
                + andrea.Idade + " anos " + andrea.Genero);

            Console.WriteLine(douglas.Nome + " " 
                + douglas.Idade + " anos " + douglas.Genero);

            Pessoa leia = new Pessoa
            {
                Nome = "Leia",
                Idade = 57,
                Genero = Util.Genero.Feminino
            };

            Pessoa kennedy = new Pessoa
            {
                Nome = "Kennedy",
                Idade = 60,
                Genero = Util.Genero.Masculino
            };

            Console.WriteLine(leia);
            Console.WriteLine(kennedy);

        }
    }
}
