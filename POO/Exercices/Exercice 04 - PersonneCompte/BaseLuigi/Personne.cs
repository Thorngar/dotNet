using System;

namespace Exercice4PersonneCompte
{
    class Personne
    {
        private string Nom;
        private string Prenom;
        private CompteCourant CompteCourant;
        private CompteEpargne CompteEpargne;

        public Personne(string Nom, string Prenom, CompteCourant CompteCourant, CompteEpargne CompteEpargne)
        {
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.CompteCourant = new CompteCourant();
            this.CompteEpargne = new CompteEpargne();
        }

        public Personne()
        {

        }

        public string GetInfos()
        {
            return "Nom : " + this.Nom + " Prénom : "+ this.Prenom + " Solde du Compte Courant : " + this.CompteCourant.GetAccountBalance() + " Solde du Compte Epargne : " + this.CompteEpargne.GetAccountBalance();
        }

        public void TransfertBetweenAccount(int Montant, CompteCourant CompteEnvoyeur, CompteCourant CompteReceveur)
        {
            CompteEnvoyeur.Retirer(Montant);
            CompteReceveur.Deposer(Montant);
        }
    }
}
