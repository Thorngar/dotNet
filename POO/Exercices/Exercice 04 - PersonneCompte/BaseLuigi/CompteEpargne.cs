using System;

namespace Exercice4PersonneCompte
{
    class CompteEpargne:IInterfaceCompte
    {
        private int Montant;

        public void Deposer(int Montant)
        {
            this.Montant = this.Montant + Montant;
        }

        public void Retirer(int Montant)
        {
            this.Montant = this.Montant - Montant;
        }

        public CompteEpargne(int Montant)
        {
            this.Montant = Montant;
        }

        public CompteEpargne()
        {
            
        }

        public int GetAccountBalance()
        {
            return this.Montant;
        }

        public void TransfertEpargneCourant(int Montant, CompteEpargne CompteEpargne, CompteCourant CompteCourant)
        {
            CompteEpargne.Montant = CompteEpargne.Montant-Montant;
            CompteCourant.Deposer(Montant);
        }
    }
}
