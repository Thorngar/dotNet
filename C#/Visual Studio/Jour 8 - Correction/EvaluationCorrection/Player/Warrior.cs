using EvaluationCorrection.Weapon;

namespace EvaluationCorrection.Player
{
    class Warrior : Player
    {
        private int Shield;

        public Warrior(int healthPoint)
        {
            this.HealthPoint = healthPoint;
            this.Weapon = new Sword(5, true);
            this.Shield = 25;
        }

        public override void Attack(Player p)
        {
            base.Attack(p);
        }

        public override void ReceiveDamage(int dmg)
        {
            if(this.Shield > 0)
            {
                if(dmg > this.Shield)
                {
                    dmg -= this.Shield;
                    this.Shield = 0;
                }
                else
                {
                    this.Shield -= dmg;
                    dmg = 0;
                }
            }
            
            this.HealthPoint -= dmg;
        }

        public override int GetWeaponDamage()
        {
            return this.Weapon.GetDamage();
        }

        public bool IsWeaponMagic()
        {
            return ((Sword)this.Weapon).IsSwordMagic();
        }

        public override string ToString()
        {
            return base.ToString() + " Bouclier: " + this.Shield;
        }
    }
}
