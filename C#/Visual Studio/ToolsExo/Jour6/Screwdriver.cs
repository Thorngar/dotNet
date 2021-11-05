using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jour6
{
    class Screwdriver:Tools
    {
        public const int MoreDamage = 6;
        public Screwdriver(int Price) : base(Price)
        {
            this.Damage += MoreDamage;
        }
    }
}
