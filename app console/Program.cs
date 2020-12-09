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
            Salarie.GlobalId = 0;
            List<Salarie> salaries = new List<Salarie>
            {
                new Salarie(),
                new Salarie(),
                new Salarie(),
                new Salarie(),
                new Salarie(),
                new Salarie(),
                new Salarie(),
                new Salarie(),
                new Salarie(),
                new Salarie(),
            };
            
            foreach(Salarie salarie in salaries)
            {
                Console.WriteLine(salarie.Id);
            }

            Animal chat = new Animal(5, 20, "Miaw", "Chat description");
            Aigle aigle = new Aigle(7, 14);
            Console.WriteLine(aigle.Vieillie());
            Chien chien = new Chien(5, 15, "NomChien");

        }

    }
}
