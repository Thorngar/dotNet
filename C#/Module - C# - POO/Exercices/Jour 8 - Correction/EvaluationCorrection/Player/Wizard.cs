
using EvaluationCorrection.Weapon;
using EvaluationCorrection.Enum;

namespace EvaluationCorrection.Player
{
    class Wizard : Player
    {
        private int MagicPoint;

        public Wizard(int healthPoint)
        {
            this.HealthPoint = healthPoint;
            this.MagicPoint = 10;
            this.Weapon = new MagicWand(EnchantmentTypeEnum.Fire);
        }

        public override void Attack(Player p)
        {
            base.Attack(p);
        }

        public override void ReceiveDamage(int dmg)
        {
            base.ReceiveDamage(dmg);
        }

        public override int GetWeaponDamage()
        {
            if (this.MagicPoint > 0)
            {           
                MagicPoint--;
                return this.Weapon.GetDamage();
            }
            else
            {
                return HAND_DAMAGE;
            }
        }
    }
}
