using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Arme;

namespace Training.Personnage
{
    class Mage : Personnage
    {
        private int Mana;
        Arme.Baton Baton;
        public Mage(string nom, int mana, Baton baton) : base(nom)
        {
            this.Nom = nom;
            this.Vie -= 20;
            this.Force += 10;
            this.Mana = mana;
            this.Baton = baton;
        }

        public override void Attaque(Personnage P)
        {
            P.RecevoirDegats(this.Intel + Baton.GetDegats());
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
                "|----------> Votre Mana" + "\n" +
                "|----------> " + this.Mana + "\n" +
                Baton.ToString();
            }
            else
            {
                return "\n" + "Vous êtes mort : " + this.Nom;
            }
        }
    }
}
