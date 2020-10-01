using Microsoft.VisualBasic.CompilerServices;
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
            float nombre;
            Console.WriteLine("Veillez saisir un nombre");
            if(float.TryParse(Console.ReadLine(), out nombre) == true)
            {
                if (nombre > 0)
                {
                    Console.WriteLine(nombre);
                } else
                {
                    Console.WriteLine("{0}", -nombre);
                }
            } else
            {
                Console.WriteLine("Saisie incorrecte");
            }
            */
            Console.WriteLine("Veuillez saisir un mot :");
            String mot = Console.ReadLine();
            int tailleMot = mot.Length;
            bool validation = true;
            for (int i = 1; i <= tailleMot; i++)
            {
                if (mot[i - 1] == mot[tailleMot - i] == false)
                {
                    validation = false;
                    break;
                }
            }
           
            if(validation)
            {
                Console.WriteLine("Oui");
            } else
            {
                Console.WriteLine("Non");
            }
        }
    }
}
