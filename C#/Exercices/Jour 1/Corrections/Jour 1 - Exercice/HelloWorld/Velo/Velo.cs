using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Velo
{
    class Velo
    {
        private string Marque;
        private int Prix;
        private Boolean IsVendu;

        public Velo(string marque, int prix)
        {
            this.Marque = marque;
            this.Prix = prix;
            this.IsVendu = false;
        }

        public void VendreVelo()
        {
            Random Random = new Random();
            int SecondsToWait = Random.Next(1, 10);
            Console.WriteLine("Temps de vente estimé: 10 secondes");
            Console.WriteLine("En attente...");

            System.Threading.Thread.Sleep(SecondsToWait * 1000);

            IsVendu = true;

            Console.Beep();
            Console.WriteLine("Le velo a été vendu en " + SecondsToWait + " secondes");
            ToString();


        }

        public override string ToString()
        {
            return "Marque: " + this.Marque + "\n" + "Prix: " + this.Prix + "Vendu: " + (IsVendu ? "Oui": "Non");
        }
    }
}
