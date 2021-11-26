using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesGetterSetter
{
    class Personne
    {
        public virtual string Nom
        {
            get 
            {
                return Nom;
            } 
            set
            {
                Nom = value;
            }
        }

        private string Prenom;
        private int Age;

        public Personne(string nom, string prenom, int age)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Age = age; 
        }
    }
}
