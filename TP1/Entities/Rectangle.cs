namespace TP1
{
    public class Rectangle : Forme
    {
        private int largeur;
        private int longueur;

        public Rectangle()
        {
        }

        public Rectangle(int longueur)
        {
            Longueur = longueur;
        }

        public Rectangle(int largeur, int longueur)
        {
            Largeur = largeur;
            Longueur = longueur;
        }

        public int Largeur { get => largeur; set => largeur = value; }
        public int Longueur { get => longueur; set => longueur = value; }

        public override double Aire()
        {
            return Largeur * longueur;
        }

        public override double Perimetre()
        {
            return (largeur + longueur) * 2;
        }

        public override string ToString()
        {
            return "Rectangle de longueur = " + longueur + " et de largeur = " + largeur + "\nAire = " + this.Aire() + "\nPérimètre = " + this.Perimetre() + "\n";
        }
    }
}