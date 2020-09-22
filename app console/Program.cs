using System;
using System.Collections.Generic;
using System.Linq;

namespace app_console
{
    class Program
    {
        static void Main()
        {
            /*
            Console.WriteLine("Entrez la veleur du côté A !");
            String CA = Console.ReadLine();
            Console.WriteLine("Entrez la veur du côté B");
            String CB = Console.ReadLine();
            int A = int.Parse(CA);
            int B = int.Parse(CB);
            int resultat = (A * A) + (B * B);
            Console.WriteLine("Hypo = {0}", resultat);
            */

            /*
            List<int> valeurs = new List<int>();
            Console.WriteLine("Entrez la valeur du côté A");
            valeurs.Add(int.Parse(Console.ReadLine()));
            Console.WriteLine("Entrez la valeur du côté B");
            valeurs.Add(int.Parse(Console.ReadLine()));
            Console.WriteLine("Entrez la valeur du côté C");
            valeurs.Add(int.Parse(Console.ReadLine()));
            int nombre = 0;
            foreach(int valeur in valeurs)
            {
                if(valeur > nombre)
                {
                    nombre = valeur;
                }
            }
            valeurs.Remove(nombre);
            int nombre1 = valeurs.First();
            int nombre2 = valeurs.Last();
            int resultat = (nombre1 * nombre1) + (nombre2 * nombre2);
            if(nombre * nombre == resultat)
            {
                Console.WriteLine("Ce triangle est rectangle");
            } else
            {
                Console.WriteLine("Ce triangle n'est pas rectangle");
            }
            */
            for(int nombre1 = 1; nombre1 < 100; nombre1++)
            {
                int nombre2 = 1;
                int divise = 0;
                while(nombre2 <= 100)
                {
                    if(nombre1 % nombre2 == 0)
                    {
                        divise++;
                    }
                    nombre2++;
                }
                if(divise < 3) 
                {
                    Console.WriteLine(nombre1);
                }
                nombre1++;
            }




        }
    }
}
