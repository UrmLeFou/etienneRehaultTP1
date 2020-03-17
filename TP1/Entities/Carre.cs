using System;

namespace TP1
{
    public class Carre : Rectangle
    {
        public override double Aire()
        {
            return Math.Sqrt(this.Longueur);
        }

        public override double Perimetre()
        {
            return this.Longueur * 4;
        }

        public override string ToString()
        {
            return "Carré de côté " + this.Longueur + "\nAire = " + this.Aire() + "\nPérimètre = " + this.Perimetre() + "\n";
        }
    }
}