using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Arme;

namespace Training.Personnage
{
    class Guerrier : Personnage
    {
        private int Defense;
        Hache Hache;
        public Guerrier(string nom, int defense, Hache hache) : base(nom)
        {
            this.Vie += 50;
            this.Force += 10;
            this.Defense = defense;
            this.Hache = hache;
        }

        public override void Attaque(Personnage P)
        {
            P.RecevoirDegats(this.Force + Hache.GetDegats());
        }

        public override string ToString()
        {
            if (this.Vie != 0)
            {
                return 
                "|----------> Vos Points de Vie" + "\n" +
                "|----------> " + this.Vie + "\n" +
                "|----------> Votre Force" + "\n" +
                "|----------> " + this.Force + "\n" +
                "|----------> Votre Intelligence" + "\n" +
                "|----------> " + this.Intel + "\n" +
                "|----------> Votre Défense" + "\n" +
                "|----------> " + this.Defense + "\n" +
                Hache.ToString();
            }
            else
            {
                return "\n" + "Vous êtes mort : " + this.Nom;
            }
        }
    }
}
