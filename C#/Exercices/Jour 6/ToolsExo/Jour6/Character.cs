using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jour6
{
    class Character
    {
        private string Nom;
        private string Prenom;
        // private List<Tools> Outils;
        private int Life = 100;
        private Tools Outils;

        public Character(string nom, string prenom, Tools outils)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Outils = outils;
            // this.Outils = new List<Tools>();
        }                
        public Character(Tools outils)
        {
            
            this.Outils = outils;
        }        
        public Character(string nom, string prenom)
        {
            this.Nom = nom;
            this.Prenom = prenom;
        }

/*        public void AddTool(Tools o)
        {
            Outils.Add(o);
        }*/

        public void ToHit(Character c)
        {
            c.ReceiveDamage(this.Outils.GetDamage());
        }

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
            int value = GetLife() - i > 0 ? GetLife() - i: 0 ;
            SetLife(value);
        }

        /*public override string ToString()
        {
            if (this.Life != 0)
            {
                return "Le bricoleur " + this.Prenom + " " + this.Nom + "\n" + "Sa vie : " + GetLife() + "\n";
            }
            else
            {
                return "\n" + "Vous êtes mort : " + this.Prenom + " " + this.Nom;
            }
        }*/

        public override string ToString()
        {
            return "Je suis " + this.Nom + " " + this.Prenom;
        }

        /*public override string ToString()
        {
            string Chaine = "Cette personne s'appelle " + this.Nom + " " + this.Prenom + " et j'ai : " ;
            foreach (Tools t in this.Outils)
            {
                Chaine += t.ToString();
            }
            return Chaine;
        }

        public string GetTool()
        {
            int compteurMarteau = 0;
            foreach (Tools t in this.Outils)
            { 
                if (t is Hammer)
                {
                    compteurMarteau++;
                }
            }
            return "J'ai des outils dont " + compteurMarteau + (compteurMarteau>1? " marteaux" : " marteau");
        }

        public int CompteurOutils()
        {
            return this.Outils.Count;
        }*/
    }
}
