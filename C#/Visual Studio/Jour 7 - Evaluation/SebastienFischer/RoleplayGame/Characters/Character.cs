using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayGame.Characters
{
    public abstract class Character
    {
        protected string Name;
        protected int Life;

        public Character(string name, int Life)
        {
            this.Name = name;
            this.Life = 100;
        }

        public abstract void ToHit(Character c);

        public int GetLife()
        {
            return this.Life;
        }

        public void SetLife(int a)
        {
            if (a >= 0)
            {
                this.Life = a;
            }
        }

        public void ReceiveDamage(int i)
        {
            int value = GetLife() - i > 0 ? GetLife() - i : 0;
            SetLife(value);
        }

        public virtual string InCaseOfWin()
        {
            return "Le personnage " + this.Name + " a gagné le combat !";
        }

        /*        public virtual void InCaseOfWin()
                {
                    string tempWin = "";
                    if (this.Life > 0)
                    {
                        tempWin = "Le personnage : " + this.Name + " a gagné le combat !";
                    }
                    else
                    {
                        return;
                    }
                }*/

        public override string ToString()
        {
            return 
                "Je me prénomme : " + this.Name + ", je possède " + this.Life + " points de vie.";
        }
    }
}

