using System;
using System.Collections.Generic;
using System.Text;

namespace app_console
{
    public class Voiture
    {
        public string Couleur { get; set; }
        public string Marque { get; set; }
        public int Vitesse { get; set; }

        public override bool Equals(object obj)
        {
            Voiture v = obj as Voiture;
            if(v == null)
            {
                return false;
            }
            return Vitesse == v.Vitesse && Couleur == v.Couleur && Marque == v.Marque;
        }
    }
}
