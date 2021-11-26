using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayGame.Weapons
{
    class MagicWand
    {
        private int Damage = 10;
        private string WeaponName;
        private EnchantmentTypeEnum EnchantmentTypeEnum;

        public MagicWand(string weaponName, EnchantmentTypeEnum enchantmentTypeEnum)
        {
            this.WeaponName = weaponName;
            this.EnchantmentTypeEnum = enchantmentTypeEnum;

            switch (enchantmentTypeEnum)
            {
                case EnchantmentTypeEnum.Feu:
                    this.Damage += 2;
                    break;
                case EnchantmentTypeEnum.Glace:
                    this.Damage = 10;
                    break;
            }
        }

        public string GetMagicWand()
        {
            return "Mon arme s'appelle : " + this.WeaponName;
        }
        public int GetWandDamage()
        {
            return this.Damage;
        }
    }
}
