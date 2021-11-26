using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoleplayGame.Weapons;

namespace RoleplayGame.Characters
{
    class Warrior:Character
    {
        private Sword Sword;
        private int BarrierShield = 25;

        public Warrior(string name, int life, Sword sword) : base(name, life)
        {
            this.Life += BarrierShield;
            this.Sword = sword;
            // Sword Sword1 = new Sword("Deuillegivre"); // Essai de composition
        }

        public override void ToHit(Character c)
        {
            c.ReceiveDamage(Sword.GetSwordDamage());
        }

        public override string InCaseOfWin()
        {
            return "Le guerrier " + this.Name + " a gagné le combat !";
        }

        /*        public override void InCaseOfWin()
                {
                    string tempWin = "";

                    if (this.Life > 0)
                    {
                        tempWin = "Le guerrier " + this.Name + " a gagné le combat !";
                    }
                    else
                    {
                        return;
                    }
                }*/

        public override string ToString()
        {
            if (this.Life == 125)
            {
                return 
                    "Je me prénomme : " + this.Name + ", je possède " + this.Life + " points de vie." + "\n" +
                    Sword.GetSword() + "\n";
            }
            else if (this.Life != 0)
            {
                return 
                    "Le guerrier " + this.Name + " attaque l'autre personnage et possède encore " + this.Life + " points de vie." + "\n";
            }
            else
            {
                return 
                    "Le personnage " + this.Name + " est mort au combat." + "\n";
            }            
        }
    }
}

