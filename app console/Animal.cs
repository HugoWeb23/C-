using System;
using System.Collections.Generic;
using System.Text;

namespace app_console
{
    public class Animal
    {
        protected string Prenom;

        public Animal()
        {
            this.Prenom = "Marcel";
        }

        public Animal(string prenom)
        {
            this.Prenom = prenom;
        }

        public virtual void Respirer()
        {
            Console.WriteLine("Je m'appelle {0} et je respire !", Prenom);
        }
    }
}
