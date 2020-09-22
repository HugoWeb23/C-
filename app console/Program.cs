using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace app_console
{
    class Program
    {
        static void Main()
        {
            var number = new Random();
            int randomNuber = number.Next(0, 100);
            bool part = false;
            int essais = 0;
            int limite = 0;
            Console.WriteLine("Définir une limite d'essais ? oui / non");
            String userLimit = Console.ReadLine();
            if(userLimit == "oui")
            {
                Console.WriteLine("Définissez une limite via un nombre ex: 5");
                userLimit = Console.ReadLine();
                limite = int.Parse(userLimit);
            }
            while (part == false)
            {
                if (essais >= limite && limite > 0)
                {
                    Console.WriteLine("Perdu! Vous avez dépassé le nombre de tentatives ! ({0})", limite);
                    break;

                }
                else
                {
                    Console.WriteLine("Essayez de trouver le nombre");
                    String userReponse = Console.ReadLine();
                    int tentative = int.Parse(userReponse);
                    if (tentative == randomNuber)
                    {
                        Console.WriteLine("Gangné!, vous avez trouvé le nombre en {0} tentatives", essais);
                        part = true;
                        break;
                    }
                    else if (tentative < randomNuber)
                    {
                        Console.WriteLine("Plus haut!");
                        essais++;
                    }
                    else if (tentative > randomNuber)
                    {
                        Console.WriteLine("Plus bas!");
                        essais++;
                    }
                }
            }



        }
    }
}
