using System;

namespace TP1
{
    public class Cercle : Forme
    {
        private int rayon;

        public Cercle()
        {
        }

        public Cercle(int rayon)
        {
            Rayon = rayon;
        }

        public int Rayon { get => rayon; set => rayon = value; }

        public override double Aire()
        {
            return Math.PI * Math.Sqrt(rayon);
        }

        public override double Perimetre()
        {
            return 2 * Math.PI * rayon;
        }

        public override string ToString()
        {
            return "Cercle de rayon " + rayon + "\nAire = " + this.Aire() + "\nPérimètre = " + this.Perimetre() + "\n";
        }
    }
}