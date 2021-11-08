using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jour4
{
    class Joueur
    {

            private string Nom;
            private string Prenom;
            private int Age;
            private int Numero;

            public Joueur(string Nom, string Prenom, int Age, int Numero)
            {
                this.Nom = Nom;
                this.Prenom = Prenom;
                this.Age = Age;
                this.Numero = Numero;
            }

            public int GetAge()
            {
                return this.Age;
            }

        public override bool Equals(Object obj)
        {
            if (obj is Joueur) // c'est le principe du boxing / unboxing
            {
                return this.Numero == ((Joueur)obj).Numero; // cast de l'objet obj en joueur
            } 
            else
            {
                return false;
            }
        }

        public override string ToString()
            {
                return "[" + this.Nom + ", " + this.Prenom + ", " + this.Age + ", " + this.Numero + "]";
            }
        
    }

}

