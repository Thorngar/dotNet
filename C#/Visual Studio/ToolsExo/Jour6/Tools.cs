using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jour6
{
    public abstract class Tools
    {
        protected int Price;
        protected int Damage = 5;

        public Tools(int Price)
        {
            this.Price = Price;
        }

        public Tools(int Price, int Damage)
        {
            this.Price = Price;
            this.Damage = Damage;
        }

        public int GetDamage()
        {
            return this.Damage; 
        }

        public override string ToString()
        {
            return "Je suis un outil et je coûte " + this.Price;
        }
    }
}
