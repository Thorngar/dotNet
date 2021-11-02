using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice02
{
    class Conducteur
    {
        private string Nom;
        private string Prenom;
        private Voiture Voiture;

        public Conducteur(string Nom, string Prenom, Voiture Voiture)
        {
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Voiture = Voiture;
        }

        public void AvancerVoiture(int Kilometrage)
        {
            Voiture.Avancer(Kilometrage);
        }
        public override string ToString()
        {
            return
                "Nom : " + this.Nom + "\n" +
                "Prenom : " + this.Prenom + "\n" +
                Voiture.ToString();
        }
    }
}
