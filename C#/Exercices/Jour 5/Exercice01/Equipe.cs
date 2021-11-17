using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercice01.PersonnalException;

namespace Exercice01
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
                if (!Joueurs.Contains(j))
                {
                    Joueurs.Add(j);
                }
            }
            else
            {
                throw new AgeException("Mauvais age");
            }
        }
        public void AjouterUnJoueurParNumero(int a)
        {
                    Joueurs.FindIndex(List<Joueur>(a));
        }

        public void SupprimerUnJoueur(Joueur j)
        {
            Joueurs.Remove(j);
        }


        public void SupprimerUnJoueurParNumero(int i)
        { 
            Joueurs.RemoveAt(i);          
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
