using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jour6
{
    class Driver: Tools
    {
        public const int MoreDamage = 12;
        
        public Driver(int Price) : base(Price)
        {
            this.Damage += MoreDamage;
        }
    }
}
