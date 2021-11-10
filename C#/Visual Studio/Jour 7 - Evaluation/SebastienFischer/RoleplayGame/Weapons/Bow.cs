using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayGame.Weapons
{
    public class Bow
    {
        private int Damage = 15;
        private string WeaponName;

        public Bow(string weaponName)
        {
            this.WeaponName = weaponName;
        }

        public string GetBow()
        {
            return "Mon arme s'appelle : " + this.WeaponName;
        }

        public int GetBowDamage()
        {
            return this.Damage;
        }
    }
}
