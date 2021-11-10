using CorrectionRoleplayGame.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionRoleplayGame.Weapon
{
    class MagicWand : Weapon
    {
        private EnchantmentTypeEnum EnchantmentTypeEnum;
        public MagicWand(EnchantmentTypeEnum enchantmentTypeEnum)
        {
            this.EnchantmentTypeEnum = enchantmentTypeEnum;
        }

        public override int GetDamage()
        {
            return EnchantmentTypeEnum switch
            {
                EnchantmentTypeEnum.Fire => this.Damage + 2,
                EnchantmentTypeEnum.Ice => this.Damage,
                _ => this.Damage
            };
        }
    }
}
