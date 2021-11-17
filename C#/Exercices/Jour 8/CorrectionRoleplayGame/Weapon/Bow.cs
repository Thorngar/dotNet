using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionRoleplayGame.Weapon
{
    class Bow : Weapon
    {
        public Bow(int damage)
        {
            this.Damage = damage;
        }

        public override int GetDamage()
        {
            return base.GetDamage();
        }
    }
}
