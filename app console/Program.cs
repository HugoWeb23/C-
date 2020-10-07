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
            // Exercice A

            int nombre;
            Console.WriteLine("Veuillez saisir un nombre");
            if(int.TryParse(Console.ReadLine(), out nombre) == false)
            {
                Console.WriteLine("Saisie invalide !");
            } else {
            if(nombre % 3 == 0)
            {
                Console.WriteLine("Ce nombre est divisible par 3");
            } else
            {
                Console.WriteLine("Ce nombre n'est pas divisible par 3");
            }
            }
            */

            // Exercice B

            /*
            int nombre;
            bool termine = false;
                while (termine == false)
                {
                    Console.WriteLine("Veuillez saisir un nombre");
                    if (int.TryParse(Console.ReadLine(), out nombre) == false)
                    {
                    Console.WriteLine("Saisie invalide !");
                    break;
                    }
                if (nombre < 10)
                    {
                        Console.WriteLine("Plus grand !");
                    }
                    if (nombre > 20)
                    {
                        Console.WriteLine("Plus petit !");
                    }
                    if(nombre >= 10 && nombre <= 20)
                     {
                    termine = true;
                    break;
                      }
                    }

            */
            int nombre;
            Console.WriteLine("Veuillez saisir un nombre");
            if (int.TryParse(Console.ReadLine(), out nombre) == false)
            {
                Console.WriteLine("Saisie invalide !");
            }
            Console.WriteLine(Somme(nombre));



        }

        static int Somme(int nombre)
        {
            int resultat = 0;
            for (int i = nombre; i > 1; i--)
            {
                int tempo = nombre;
                tempo = tempo + i--;
                 resultat = resultat + tempo;

            }
            return resultat;
        }

    }
}
