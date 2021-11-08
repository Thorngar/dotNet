using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jour4.PersonnalException;

namespace Jour4
{
    class Equipe
    {
        private string Nom;
        private List<Joueur> Joueurs;

        public Equipe(string Nom)
        {
            this.Nom = Nom;
            Joueurs = new List<Joueur>();
        }

        public void AjouterUnJoueur(Joueur j)
        {
            if (j.GetAge() <= 18)
            {
                if (!Joueurs.Contains(j)) // .Contains utilise .Equals qui a été override dans Joueur.cs
                {
                    Joueurs.Add(j);
                }
                else
                {
                    throw new AgeException("Mauvais âge");
                }
            }
        }       

        public void SupprimerUnJoueur(Joueur j)
        {
            Joueurs.Remove(j);
        }

        public override string ToString()
        {
            string tempStringList = "";
            foreach (Joueur j in Joueurs)
            {
                tempStringList += j.ToString();
            }
            return tempStringList;
        }
    }
}
