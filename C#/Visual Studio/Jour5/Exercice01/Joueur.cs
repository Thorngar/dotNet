using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice01
{
    class Joueur
    {
        private string Nom;
        private string Prenom;
        private int Age;
        private int Numero;
        private int id;

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

        public int GetNumero()
        {
            return this.Numero;
        }
        public override bool Equals(Object obj)
        {
            if (obj is Joueur)
            {
                return this.id == ((Joueur)obj).id;
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
