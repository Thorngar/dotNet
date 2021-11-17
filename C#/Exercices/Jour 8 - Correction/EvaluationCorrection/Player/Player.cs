

using System;
using EvaluationCorrection.Weapon;

namespace EvaluationCorrection.Player
{
    abstract class Player : IFightable
    {
        public const int HAND_DAMAGE = 5;
        protected int HealthPoint;
        protected Weapon.Weapon Weapon;

        public virtual void Attack(Player p)
        {
            if(p is Warrior && ((Warrior)p).IsWeaponMagic())
            {
                Random random = new Random();
                int probReturnDamage = random.Next(0, 100);

                if(probReturnDamage <= 25)
                {
                    this.ReceiveDamage(GetWeaponDamage());
                }
                else
                {
                    p.ReceiveDamage(GetWeaponDamage());
                }
            }
            else
            {
                p.ReceiveDamage(GetWeaponDamage());
            }           
        }

        public virtual void ReceiveDamage(int dmg)
        {
            this.HealthPoint -= dmg;
        }

        public virtual int GetWeaponDamage()
        {
            return this.Weapon.GetDamage();
        }

        public virtual int GetHealthPoint()
        {
            return this.HealthPoint;
        }

        public override string ToString()
        {
            return
                "Joueur: " + this.GetType().Name +
                " Point de vie: " + this.HealthPoint +
                " Arme: " + this.Weapon.GetType().Name;
        }
    }
}
