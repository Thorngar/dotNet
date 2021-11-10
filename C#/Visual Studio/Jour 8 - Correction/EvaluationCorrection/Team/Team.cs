
using System;
using System.Collections.Generic;
using System.Linq;

namespace EvaluationCorrection.Team
{
    class Team
    {
        private List<Player.Player> Players;
        private readonly string TeamName;

        public Team(string teamName)
        {
            this.Players = new List<Player.Player>();
            this.TeamName = teamName;
        }

        public void AddPlayer(params Player.Player[] players)
        {
            foreach(Player.Player p in players)
            {
                this.Players.Add(p);
            }  
        }

        public void ShuffleTeamPlayers()
        {
            this.Players = this.Players.OrderBy(a => Guid.NewGuid()).ToList();
        }

        public List<Player.Player> GetPlayerList()
        {
            return this.Players;
        }

        public bool HasStillPlayersAlive()
        {
            foreach(Player.Player p in Players)
            {
                if(p.GetHealthPoint() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }

        public override string ToString()
        {
            string tmp = "";
            foreach(Player.Player p in Players)
            {
                tmp += p.ToString() + "\n";
            }

            return tmp;
        }

    }
}
