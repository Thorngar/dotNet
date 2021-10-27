using System;

namespace MonPremierProjet
{
    public class Test 
    {
        public static void Main(string[] args)
        {
            Article Article1 = new Article ("Georges", 2999.99); // Instance d'un objet
            Console.WriteLine(Article1.ToString());
            Ordinateur Ordinateur1 = new Ordinateur ("PC", 1999.99, "i5", 1024);
            Console.WriteLine(Ordinateur1.ToString());
            Playstation Playstation1 = new Playstation ("PlayStation", 499.99, "PS5", "noire");
            Console.WriteLine(Playstation1.ToString());
        }
    }

    public class Article
    {
        private String Nom; // String -> Chaîne de caractères / double -> Chiffre à virgule
        private double Prix; // Attributs

        public Article(String Nom, double Prix) // Constructeur
        {
            this.Nom = Nom;
            this.Prix = Prix;
        }
        public String GetNom() // Méthode créee pour la reprendre d'une classe enfant vu que les attributs sont privés, grâce à cette méthode, on ne peut pas modifier les attributs de base mais faire appel à la fonction d'une autre méthode
        {
            return this.Nom;
        }
        public double GetPrix()
        {
            return this.Prix;
        }
        public virtual String ToString() // virtual -> permet aux classes enfants d'override la méthode
        {
            return "Je suis un Article, mon nom est " + this.Nom + ", mon prix est de " + this.Prix + " euros";
        }
    }
    public class Ordinateur:Article // ClassEnfant:ClassParent -> Héritage de la classe parent
    {
        private String CPU;
        private int RAM;
        // public Ordinateur (String MéthodeParent, double Méthode Parent, String NouvelAttributClasseEnfant, int NouvelAttributClasseEnfant):base(MéthodeParent, MéthodeParent) // :base -> Appel des méthodes parents 
        public Ordinateur(String Nom, double Prix,String CPU, int RAM):base(Nom, Prix)
        {
            this.CPU = CPU;
            this.RAM = RAM;
        }
        public override String ToString() // Réecriture de la MéthodeParent grâce à override 
        {
            return "Je suis un " + this.GetNom() +", j'ai un CPU " + this.CPU + " et une RAM de " + this.RAM + " MB";
        }
    }
    public class Playstation:Article // ClassEnfant:ClassParent -> Héritage de la classe parent
    {
        private String Modèle;
        private String Couleur;
        public Playstation(String Nom, double Prix, String Modèle, String Couleur):base(Nom, Prix) 
        {
            this.Modèle = Modèle;
            this.Couleur = Couleur;
        }
        public override String ToString()
        {
            return "Je suis une " + this.GetNom() + ", mon modèle est " + this.Modèle + " et je coûte " + this.GetPrix() + " euros, ma couleur est " + this.Couleur;
        }
    }
}