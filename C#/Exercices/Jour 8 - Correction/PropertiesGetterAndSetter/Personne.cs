using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesGetterAndSetter
{
    class Personne
    {
        public string Nom { get; }
        public string Prenom { get; set; }
        public int Age { get; }

        public Personne(string nom, string prenom, int age)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Age = age;
        }


    }
}
