using System;
using EvaluationCorrection.Weapon;

namespace EvaluationCorrection.Player
{
    class Archer : Player
    {
        private int NbArrow;
        private double ChanceToHit;

        public Archer(int healthPoint, int nbArrow, double chanceTohit)
        {
            this.HealthPoint = healthPoint;
            this.NbArrow = nbArrow;
            this.ChanceToHit = chanceTohit;
            this.Weapon = new Bow(5);
        }

        public override void Attack(Player p)
        {
            base.Attack(p);
        }

        public override void ReceiveDamage(int dmg)
        {
            this.HealthPoint -= dmg;
        }

        public override int GetWeaponDamage()
        {
            if (this.NbArrow > 0)
            {
                Random random = new Random();
                int prob = random.Next(0, 100);
                this.NbArrow--;

                if (prob <= ChanceToHit * 100)
                {
                    return this.Weapon.GetDamage();                
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return HAND_DAMAGE;
            }
        }
    }
}
