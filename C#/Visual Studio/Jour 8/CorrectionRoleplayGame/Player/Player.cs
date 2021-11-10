using CorrectionRoleplayGame.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionRoleplayGame.Player
{
    public abstract class Player : IFightable
    {
        public const int HAND_DAMAGE = 5;
        protected int HealthPoint;
        protected Weapon.Weapon Weapon;

        public virtual void Attack(Player p)
        {
            if (p is Warrior && ((Warrior)p).IsWeaponMagic())
            {
                Random random = new Random();
                int probReturnDamage = random.Next(0, 100);

                if (probReturnDamage <= 25)
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
                "Joueur : " + this.GetType().Name + "\n" +
                "Points de vie : " + this.HealthPoint + "\n" +
                "Arme : " + this.Weapon.GetType().Name;
        }
    }
}
