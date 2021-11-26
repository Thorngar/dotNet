using System;
using ToolsExo.Model.Player;

namespace ToolsExo
{
    class Program
    {
        static void Main(string[] args)
        {
            GardenKeeper g = new GardenKeeper(150, new Hammer("Hammy", 10));

            Creature c = new Creature(120, new Hammer("Hammy", 10));

            //Before attack
            Console.WriteLine("Joueur 1 avant l'attaque");
            Console.WriteLine(c.ToString());

            //Attack
            g.HitOpponent(c);

            //After attack
            Console.WriteLine("Joueur 1 après l'attaque");
            Console.WriteLine(c.ToString());

        }
    }
}
