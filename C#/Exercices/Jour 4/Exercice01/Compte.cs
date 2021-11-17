using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice01
{
    class Compte
    {
        private double Balance;
        private string Owner;
        static int Compteur;
        static int Interest = 7;

        public Compte(string Owner, double Balance)
        {
            this.Owner = Owner;
            if (Balance >= 0)
            {
                this.Balance = Balance;
            }
            else
            {
                this.Balance = 0;
            }

            Compteur++;
        }

        public Compte(string Owner)
        {
            this.Owner = Owner;
            this.Balance = 0;
            Compteur++;
        }

        public static int GetCompteur()
        {
            return Compteur;
        }

        public override string ToString()
        {
            return "Propriétaire : " + this.Owner + "\n" + "Montant : " + this.Balance;
        }
    }
}
