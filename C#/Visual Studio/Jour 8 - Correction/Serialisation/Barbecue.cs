
using System;
using Newtonsoft.Json;

namespace Serialisation
{
    [Serializable]
    class Barbecue
    {
        public string Marque;
        public int Puissance;
        public int Prix;

        public Barbecue()
        {

        }

        public Barbecue(string marque, int puissance, int prix)
        {
            this.Marque = marque;
            this.Puissance = puissance;
            this.Prix = prix;

        }

        public override string ToString()
        {
            return "Marque: " + this.Marque + " Puissance: " + this.Puissance + " Prix: " + this.Prix + "\n";
        }
    }
}
