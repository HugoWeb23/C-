using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace app_console
{
    public class Chat : Animal
    {
        public Chat(string prenom) : base(prenom)
        {
        }

        public void Miauler()
        {
            Console.WriteLine("Miaou");
        }
    }
}
