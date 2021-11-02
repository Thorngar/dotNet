using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice03
{
    public class Boisson
    {
        protected string Categorie;
        protected int Prix;

        public void Boisson(string Categorie, int Prix)
        {
            this.Categorie = Categorie;
            this.Prix = Prix;
        }

        public void IsDisponible()
        {
            
        }

        public override string ToString()
        {
            return "Il y a autant de " + this.Categorie + " disponible";
        }
    }
}
