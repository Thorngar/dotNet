using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Personnage
{
    abstract class Personnage
    {
        protected string Nom;
        protected int Vie;
        protected int Force;
        protected int Intel;

        public Personnage(string nom)
        {
            this.Nom = nom;
            this.Vie = 100;
            this.Force = 1;
            this.Intel = 1;
        }

        public abstract void Attaque(Personnage P);

        public void RecevoirDegats(int Attaque)
        {
            this.Vie -= Attaque;
        }

        public int GetVie()
        {
            return this.Vie;
        }

        public override string ToString()
        {
            if (this.Vie != 0)
            {
                return
                    "|----------> Votre Nom" + "\n" +
                    "|----------> " + this.Nom + "\n";
            }
            else
            {
                return "\n" + "Vous êtes mort : " + this.Nom;
            }
        }
    }
}
