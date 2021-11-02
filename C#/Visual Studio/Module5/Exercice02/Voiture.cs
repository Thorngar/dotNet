using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice02
{
    public class Voiture
    {
        private int Kilometrage;
        private string Marque;

        public Voiture(int Kilometrage, string Marque)
        {
            this.Kilometrage = Kilometrage;
            this.Marque = Marque;
        }        
        
        public Voiture(string Marque)
        {
            this.Kilometrage = 0;
            this.Marque = Marque;
        }

        public void Avancer(int Kilometrage)
        {
            this.Kilometrage += Kilometrage;
        }
        public override string ToString()
        {
            return "La marque est : " + this.Marque + " et son kilomètrage est de " + this.Kilometrage + "\n";
        }
    }
}
