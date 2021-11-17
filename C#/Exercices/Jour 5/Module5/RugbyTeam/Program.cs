using System;

namespace RugbyTeam
{
    class Program
    {
        static void Main(string[] args)
        {
            Joueur Joueur01 = new Joueur("Robert", "Garcia", 17, 3);
            Console.WriteLine(Joueur01.GetJoueur());

        }
    }
}
