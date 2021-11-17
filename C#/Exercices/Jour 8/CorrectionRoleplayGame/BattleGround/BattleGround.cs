using CorrectionRoleplayGame.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionRoleplayGame.BattleGround
{
    class BattleGround
    {
        private int Round = 0;
        private bool HasAlreadyFought = false;

        private Team.Team Team1;
        private Team.Team Team2;
        
        public BattleGround()
        {
            this.Team1 = new Team.Team("Team 1");
            this.Team2 = new Team.Team("Team 2");

            Archer archer1 = new Archer(120, 10, 0.5);
            Wizard wizard1 = new Wizard(90);
            Warrior warrior1 = new Warrior(70);

            Archer archer2 = new Archer(150, 10, 0.5);
            Wizard wizard2 = new Wizard(100);
            Warrior warrior2 = new Warrior(60);

            Team1.AddPlayer(archer1, wizard1, warrior1);

            Team2.AddPlayer(archer2, wizard2, warrior2);
        }

        public void Fight()
        {
            Team1.ShuffleTeamPlayers();
            Team2.ShuffleTeamPlayers();

            Console.WriteLine("Début du Combat");
            Console.WriteLine("===============");
            bool IsP1Over;

            foreach (Player.Player p1 in this.Team1.GetPlayerList())
            {
                IsP1Over = false;

                foreach (Player.Player p2 in this.Team2.GetPlayerList())
                {
                    while (true)
                    {
                        p1.Attack(p2);

                        if (p2.GetHealthPoint() <= 0)
                        {
                            break;
                        }

                        p2.Attack(p1);

                        if (p1.GetHealthPoint() <= 0)
                        {
                            IsP1Over = true;
                            break;
                        }

                        Console.WriteLine("\nEn Combat");
                        Console.WriteLine("===============");
                        Console.WriteLine(p1);
                        Console.WriteLine(p2);

                        this.Round++;
                        /*System.Threading.Thread.Sleep(500);*/
                    } 

                    if (IsP1Over)
                    {
                        break;
                    }
                }
                HasAlreadyFought = true;
            }
        }
        public override string ToString()
        {
            if (HasAlreadyFought)
            {
                if (Team1.HasStillPlayersAlive())
                {
                    return 
                        "Team 1 has won" + "\n" +
                        "Team 1" + this.Team1.ToString() + "\n" +
                        "Team 2" + this.Team2.ToString() + "\n" +
                        "Nombre de rounds : " + this.Round;
                }
                else
                {
                    return
                        "Team 2 has won" + "\n" +
                        "Team 1" + this.Team1.ToString() + "\n" +
                        "Team 2" + this.Team2.ToString() + "\n" +
                        "Nombre de rounds : " + this.Round;
                }
            }
            else
            {
                return 
                    "Team 1" + this.Team1.ToString() + "\n" 
                    + "Team 2" + this.Team2.ToString();

            }
        }
    }
}
