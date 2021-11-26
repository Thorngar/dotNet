using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoleplayGame.Weapons;


namespace RoleplayGame.Characters
{
    public class Archer:Character
    {
        private Bow Bow;
        private int ArrowsInQuiver = 30;

        public Archer(string name, int life, Bow bow) : base(name, life)
        {
            this.Life -= 20;
            this.Bow = bow;
        }

        public override void ToHit(Character c)
        {
            if (ArrowsInQuiver > 0)
            {
                Random Random = new Random();
                Random.Next(0, 10);

                int Chance = Random.Next(0, 10);

                if (Chance > 5)
                {
                    c.ReceiveDamage(Bow.GetBowDamage());
                }
                else
                {

                }

                ArrowsInQuiver--;

            }
            else
            {

            }
        }
        public override string InCaseOfWin()
        {
            return "L'archer :" + this.Name + " a gagné le combat !";
        }

        /*        public override void InCaseOfWin()
        {
            string tempWin = "";

            if (this.Life > 0)
            {
                tempWin = "L'archer " + this.Name + " a gagné le combat !";
            }
            else
            {
                return;
            }
        }*/

        public override string ToString()
        {
            if (this.Life == 80)
            {
                return
                    "Je me prénomme : " + this.Name + ", je possède " + this.Life + " points de vie." + "\n" +
                    Bow.GetBow() + "\n";
            }
            else if (this.Life != 0)
            {
                return 
                    "L'archer " + this.Name + " attaque l'autre personnage et possède encore " + this.Life + " points de vie." + "\n";
            }
            else
            {
                return 
                    "Le personnage " + this.Name + " est mort au combat." + "\n";
            }
        }
    }
}
