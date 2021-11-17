using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayGame.Weapons
{
    public class Sword
    {
        private int Damage = 20;
        private string WeaponName;
        // private bool IsMagic = false;

        public Sword(string weaponName)
        {
            this.WeaponName = weaponName;
        }

        /*        public Sword(string weaponName, bool isMagic) // Tentative de définir si oui ou non l'épée était magique
                {
                    this.IsMagic = isMagic;

                    switch (isMagic)
                    {
                        case true:
                            // Censé renvoyer les dégâts de l'ennemi
                            break;
                        case false:
                            this.Damage = 20;
                            break;
                    }
        */

        public string GetSword()
        {
            return "Mon arme s'appelle : " + this.WeaponName;
        }

        public int GetSwordDamage()
        {
            return this.Damage;
        }
    }
}

