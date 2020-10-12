using System;
using System.Collections.Generic;
using System.Linq;

namespace app_console
{
    class Program
    {
        static void Main()
        {

            Voiture voiturehugo = new Voiture { Marque = "BMW", Couleur = "Vert", Vitesse = 120 };
            Voiture voitureromain = new Voiture { Marque = "BMW", Couleur = "Vert", Vitesse = 120 };

            if(voiturehugo.Equals(voitureromain))
            {
                Console.WriteLine("OK");
            }

        }
    }
}
