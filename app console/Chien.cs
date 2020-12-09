using System;
using System.Collections.Generic;
using System.Text;

namespace app_console
{
    public class Chien : Animal
    {
        public string Nom { get; set; }
        public Chien(int age, int agemaximum, string nom) : base(age, agemaximum)
        {
            this.Nom = nom;
        }
    }
}
