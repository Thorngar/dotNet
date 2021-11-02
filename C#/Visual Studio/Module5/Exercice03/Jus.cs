using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice03
{
    class Jus:Boisson
    {
        private int NumbersOfJus;

        public Jus(int NumberOfJus):base(Categorie, Prix)
            {
            this.NumbersOfJus = NumberOfJus;
            }
    }
}
