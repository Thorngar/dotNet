using System;
using RoleplayGame.Characters;
using RoleplayGame.Weapons;

namespace RoleplayGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Bow Bow1 = new Bow("La dernière Corde");
            Sword Sword1 = new Sword("Deuillegivre");
            MagicWand MagicWand1 = new MagicWand("Atiesh", EnchantmentTypeEnum.Feu);

            Character Archer1 = new Archer("Melkior", 100, Bow1);
            Character Warrior1 = new Warrior("Arthas", 100, Sword1);
            Character Wizard1 = new Wizard("Khadgar", 100, MagicWand1);
            Character Wizard2 = new Wizard("Jaina", 100, MagicWand1);

            Console.WriteLine(Warrior1.ToString());
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine(Wizard1.ToString());
            System.Threading.Thread.Sleep(2000);

            do
            {
                Wizard1.ToHit(Warrior1);
                Warrior1.ToHit(Wizard1);

                Console.WriteLine(Warrior1.ToString());
                System.Threading.Thread.Sleep(2000);

                Console.WriteLine(Wizard1.ToString());
                System.Threading.Thread.Sleep(2000);

            } while (Wizard1.GetLife() > 0 && Warrior1.GetLife() > 0);

            Console.WriteLine(Warrior1.InCaseOfWin()); 

            // Tentative d'écrire qui a gagné le combat

            /*            if (Wizard1.GetLife() < 0) 
                        {
                            Console.WriteLine(Wizard1.InCaseOfWin());
                        }

                        if (Warrior1.GetLife() < 0)
                        {
                            Console.WriteLine(Warrior1.InCaseOfWin());
                        }
            */

            // Essai d'un autre combat 

            /*            Console.WriteLine(Archer1.ToString()); 
                        System.Threading.Thread.Sleep(2000);

                        do
                        {
                            Wizard2.ToHit(Archer1);
                            Archer1.ToHit(Wizard2);

                            Console.WriteLine(Wizard2.ToString());
                            System.Threading.Thread.Sleep(2000);

                            Console.WriteLine(Archer1.ToString());
                            System.Threading.Thread.Sleep(2000);

                        } while (Wizard2.GetLife() > 0 && Archer1.GetLife() > 0);
            */

        }
    }
}
