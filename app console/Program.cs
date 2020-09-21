using System;
using System.Collections.Generic;

namespace app_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez la veleur du côté A");
            String CA = Console.ReadLine();
            Console.WriteLine("Entrez la veur du côté B");
            String CB = Console.ReadLine();
            int A = int.Parse(CA);
            int B = int.Parse(CB);
            int resultat = (A * A) + (B * B);
            Console.WriteLine("Hypo = {0}", resultat);


        }
    }
}
