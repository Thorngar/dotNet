using System;

namespace Exercice01
{
    class Program
    {
        static void Main(string[] args)
        {
            Compte Compte1 = new Compte("Robert", 12000);
            Compte Compte2 = new Compte("Paul", 1000);
            Compte Compte3 = new Compte("Roger", 3000);
            Compte Compte4 = new Compte("Pascal", 7000);

            Console.WriteLine(Compte1.ToString());

            Console.WriteLine(Compte.GetCompteur());
        }
    }
}
