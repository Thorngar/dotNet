using System;

namespace EvaluationCorrection.Weapon
{
    class Sword : Weapon
    {
        private bool IsMagic;

        public Sword(int damage, bool isMagic)
        {
            this.Damage = damage;
            this.IsMagic = isMagic;
        }

        public override int GetDamage()
        {
            return base.GetDamage();
        }

        public bool IsSwordMagic()
        {
            return this.IsMagic;
        }
    }
}
