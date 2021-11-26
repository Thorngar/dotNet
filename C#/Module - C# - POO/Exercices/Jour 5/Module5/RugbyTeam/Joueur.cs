using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RugbyTeam
{
    class Joueur
    {
        private string Nom;
        private string Prenom;
        private int Age;
        private int Numero;

        public Joueur(string Nom, string Prenom, int Age, int Numero)
        {
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Age = Age;
            this.Numero = Numero;
        }

        public string GetJoueur()
        {
            return 
                "Le joueur s'appelle " + this.Nom + " " + this.Prenom +
                ", il a " + this.Age + " ans" + " et son numéro est : " + this.Numero;
        }
    }
}
