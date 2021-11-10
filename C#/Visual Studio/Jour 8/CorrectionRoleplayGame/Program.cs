

using CorrectionRoleplayGame.Player;
using System;

namespace CorrectionRoleplayGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int round = 0;
            Team.Team team1 = new Team.Team("Team 1");
            Team.Team team2 = new Team.Team("Team 2");

            Archer archer1 = new Archer(100, 10, 0.5);
            Wizard wizard1 = new Wizard(100);
            Warrior warrior1 = new Warrior(100);  
            
            Archer archer2 = new Archer(100, 10, 0.5);
            Wizard wizard2 = new Wizard(100);
            Warrior warrior2 = new Warrior(100);

            team1.AddPlayer(archer1, wizard1, warrior1);

            team1.AddPlayer(archer2, wizard2, warrior2);

            #region Part 1
            /* 
             Console.WriteLine("Début du Combat");
             Console.WriteLine("===============");
             Console.WriteLine(wizard);
             Console.WriteLine(warrior);

             while (true)
             {
                 archer.Attack(wizard);

                 if (wizard.GetHealthPoint() <= 0)
                 {
                     break;
                 }

                 wizard.Attack(archer);

                 if (archer.GetHealthPoint() <= 0)
                 {
                     break;
                 }

                 Console.WriteLine("\nEn Combat");
                 Console.WriteLine("===============");
                 Console.WriteLine(wizard);
                 Console.WriteLine(archer);
                 round++;
                 System.Threading.Thread.Sleep(500);
             }

             Console.WriteLine("\nFin du Combat");
             Console.WriteLine("===============");
             Console.WriteLine(wizard);
             Console.WriteLine(archer);

             Console.WriteLine("\nNombre de tours : " + round);
              */
            #endregion

            #region Part 2

            BattleGround.BattleGround bg = new BattleGround.BattleGround();

            Console.WriteLine(bg.ToString());
            bg.Fight();
            Console.WriteLine(bg.ToString());

            #endregion
        }
    }
}
