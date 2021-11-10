using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoleplayGame.Weapons;

namespace RoleplayGame.Characters
{
    class Wizard:Character
    {
        private int Mana = 10;
        private int CompteurMana;
        private MagicWand MagicWand;
        public Wizard(string name, int life, MagicWand magicWand) : base(name, life)
        {
            this.MagicWand = magicWand;
        }

        public override void ToHit(Character c)
        {
            CompteurMana = this.Mana; // Tentative de mettre -1 de Mana par attaque avec un compteur

            c.ReceiveDamage(MagicWand.GetWandDamage());
            CompteurMana--;

            string tempMana = "";

            if (CompteurMana == 0)
            {
                tempMana = "Vous n'avez plus de mana";
            }
        }

        public override string InCaseOfWin()
        {
            return "Le mage " + this.Name + " a gagné le combat !";
        }

        /*        public override void InCaseOfWin()
                {
                    string tempWin = "";

                    if (this.Life > 0)
                    {
                        tempWin = "Le mage " + this.Name + " a gagné le combat !";
                    }
                    else
                    {
                        return;
                    }
                }*/

        public override string ToString()
        {
            if (this.Life == 100)
            {
                return
                    "Je me prénomme : " + this.Name + ", je possède " + this.Life + " points de vie." + "\n" +
                    MagicWand.GetMagicWand() + "\n";
            }
            else if (this.Life != 0)
            {
                return 
                    "Le mage " + this.Name + " attaque l'autre personnage et possède encore " + this.Life + " points de vie." + "\n";
            }
            else
            {
                return 
                    "Le personnage " + this.Name + " est mort au combat." + "\n";
            }
        }
    }
}

