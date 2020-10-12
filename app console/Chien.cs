using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace app_console
{
    public class Chien : Animal
    {


        public Chien(string prenom) : base(prenom) { }
        public int NombrePattes { get; set; }

       public override void Respirer()
        {
            Console.WriteLine("OUPS !");
            base.Respirer();
        }

        public int CalculPattes(int pattes)
        {
            return pattes * 2;
        }

        public double CalculPattes(double pattes)
        {
            return pattes * 2;
        }
    }
}
