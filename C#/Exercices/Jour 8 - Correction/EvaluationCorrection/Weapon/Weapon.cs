

namespace EvaluationCorrection.Weapon
{
    abstract class Weapon
    {
        protected int Damage;

        public virtual int GetDamage()
        {
            return this.Damage;
        }

    }
}
