using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jour6
{
    class Hammer:Tools
    {
        public const int MoreDamage = 10;
        public Hammer(int Price) : base(Price)
        {
            this.Damage += MoreDamage;
        }

        public override string ToString()
        {
            return "Je suis un marteau !";
        }
    }
}
