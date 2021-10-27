using System;

namespace MonPremierProjet
{
    public class Program 
    {
        public static void Test(string[] args)
        {
            Animal Animal1 = new Animal (10);
            Console.WriteLine(Animal1.ToString());
            Chat Chat1 = new Chat (15, "Boris");
            Console.WriteLine(Chat1.ToString());
            Chien Chien1 = new Chien(20, "blanche");
            Console.WriteLine(Chien1.ToString());
        }
    }
    public class Animal    
    {
        private int Age;

        public Animal(int Age)
        {
            this.Age = Age;
        }
        public int GetAge()
        {
            return this.Age;
        }
        public override String ToString()
        {
            return "Je suis un animal \n" + "J'ai " + this.Age + " ans";
        }
    }

    public class Chat:Animal
    {
        private String Nom;
        public Chat(int Age, String Nom):base(Age)
        {
            this.Nom = Nom;
        }
        public override String ToString()
        {
            return "Je suis un chat, je m'appelle " + this.Nom + " et j'ai " + this.GetAge() + " ans";
        }
    
    }
    public class Chien:Animal
    {
        private String Couleur;
        public Chien(int Age, String Couleur):base(Age)
        {
            this.Couleur = Couleur;
        }
        public override String ToString()
        {
            return "Je suis un chien, je suis de couleur " + this.Couleur +  " et j'ai " + this.GetAge() + " ans";
        }
    }
}
