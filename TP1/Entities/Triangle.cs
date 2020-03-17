using System;

namespace TP1
{
    public class Triangle : Forme
    {
        private int a;
        private int b;
        private int c;

        public Triangle()
        {
        }

        public Triangle(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }
        public int C { get => c; set => c = value; }

        public override double Aire()
        {
            double demiPerimetre = Perimetre() / 2;
            return Math.Sqrt(demiPerimetre * (demiPerimetre - a) * (demiPerimetre - b) * (demiPerimetre - c));
        }

        public override double Perimetre()
        {
            return a + b + c;
        }

        public override string ToString()
        {
            return "Triangle de côté  A = " + a + ", B = " + b + ", C = " + c + "\nAire = " + this.Aire() + "\nPérimètre = " + this.Perimetre() + "\n";
        }
    }
}