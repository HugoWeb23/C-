using System;

namespace app_console
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] tableau = new String[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi" };
            foreach(String arg in tableau)
            {
                Console.WriteLine(arg);
            }

        }
    }
}
