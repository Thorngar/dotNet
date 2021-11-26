

namespace EvaluationCorrection.Weapon
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
