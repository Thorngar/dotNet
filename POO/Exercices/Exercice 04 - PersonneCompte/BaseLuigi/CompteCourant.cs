using System;

namespace Exercice4PersonneCompte
{
    class CompteCourant:IInterfaceCompte
    {
        private int Montant;

        public void Retirer(int Montant)
        {
            this.Montant = this.Montant - Montant;
        }

        public void Deposer(int Montant)
        {
            this.Montant = this.Montant + Montant;
        }

        public CompteCourant(int Montant)
        {
            this.Montant = Montant;
        }

        public CompteCourant()
        {
            
        }

        public int GetAccountBalance()
        {
            return this.Montant;
        }

        public void TransfertCourantEpargne(int Montant, CompteEpargne CompteEpargne, CompteCourant CompteCourant)
        {
            CompteCourant.Montant= CompteCourant.Montant - Montant;
            CompteEpargne.Deposer(Montant);
        }

    }
}
