using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionRoleplayGame.Weapon
{
    public abstract class Weapon
    {
        protected int Damage;

        public virtual int GetDamage()
        {
            return this.Damage;
        }
    }
}
