using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

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
            


            for(int nombre1 = 2; nombre1 < 100; nombre1++)
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
              
            }

            */

            /*
            List<int> notes = new List<int>();
            bool fin = false;
            while (fin == false)
            {
                Console.WriteLine("Veuillez saisir une note, tapez 'fin' pour arrêter");
                int note = 0;
                String saisie = Console.ReadLine();
                if (saisie == "fin")
                {
                    fin = true;
                    break;
                }
                if (int.TryParse(saisie, out note) == false)
                {
                    Console.WriteLine("Saisie incorrecte !");
                }
                notes.Add(note);
            }

            double total_notes = 0;
            for (int i = 0; i < notes.Count(); i++)
            {
                total_notes += notes[i];
            }
            double moyenne = total_notes / notes.Count();
            Console.WriteLine("La moyenne est : {0}", moyenne);

            */


            /*
            Console.WriteLine("Veuillez saisir une année");
            int annee = 0;
            if (int.TryParse(Console.ReadLine(), out annee) == false)
            {
                Console.WriteLine("Saisie invalide !");
            } else
            {
                if (annee % 4 == 0 && annee % 100 != 0)
                {
                    Console.WriteLine("{0} est bissextile", annee);
                } else
                {
                    Console.WriteLine("{0} n'est pas bissextile", annee);
                }
            }
            */

            List<double> notes = new List<double>();
            bool fin = false;
            while (fin == false)
            {
                Console.WriteLine("Veuillez saisir une note, tapez 'fin' pour arrêter");
                double note = 0;
                String saisie = Console.ReadLine();
                if (saisie == "fin")
                {
                    fin = true;
                    break;
                }
                if (Double.TryParse(saisie, out note) == false)
                {
                    Console.WriteLine("Saisie incorrecte !");
                }
                notes.Add(note);
            }

            double total_notes = 0;
            for (int i = 0; i < notes.Count(); i++)
            {
                total_notes += notes[i];
            }
            double moyenne = total_notes / notes.Count();
            Console.WriteLine("La moyenne est : {0}", moyenne);
            notes.Sort();
            Console.WriteLine("*******************");
            foreach(float note in notes)
            {
                Console.WriteLine(note);
            }

        }

    }
}
