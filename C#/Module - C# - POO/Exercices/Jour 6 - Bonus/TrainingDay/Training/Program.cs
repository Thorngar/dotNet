using System;
using Training.Arme;


namespace Training.Personnage
{
    class Program
    {
        static void Main(string[] args)
        {
            Hache Hache1 = new Hache("L'éventreur", 5, 20);
            Baton Baton1 = new Baton("Johny Halliday", 4, 45);

            Personnage Guerrier1 = new Guerrier("Jean-Claude", 10, Hache1);
            Personnage Mage1 = new Mage("Jean-Eude", 100, Baton1);

            do
            {
                Mage1.Attaque(Guerrier1);
                Guerrier1.Attaque(Mage1);
            } 
            while (Guerrier1.GetVie() > 0 && Mage1.GetVie() > 0);

            Console.WriteLine(Mage1.ToString());
            Console.WriteLine(Guerrier1.ToString());
        }
    }
}
