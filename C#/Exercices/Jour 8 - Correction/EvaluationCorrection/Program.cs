using System;
using EvaluationCorrection.Player;
using EvaluationCorrection.BattleGround;

namespace EvaluationCorrection
{
    class Program
    {    
        static void Main(string[] args)
        {
            #region Part1
            /*Console.WriteLine("Début du combat");
            Console.WriteLine("===============");
            Console.WriteLine(archer);
            Console.WriteLine(wizard);

            while (true)
            {
                archer.Attack(wizard);
                if(wizard.GetHealthPoint() <= 0)
                    break;

                wizard.Attack(archer);
                if (archer.GetHealthPoint() <= 0)
                    break;

                Console.WriteLine("\nEn combat");
                Console.WriteLine("===============");
                Console.WriteLine(archer);
                Console.WriteLine(wizard);
                round++;
                System.Threading.Thread.Sleep(500);

            }
        
            Console.WriteLine("\nFin du combat");
            Console.WriteLine("===============");
            Console.WriteLine(archer);
            Console.WriteLine(wizard);
            Console.WriteLine("\nNombre de tour: " + round);*/
            #endregion
            
            #region Part2
            BattleGround.BattleGround bg = new BattleGround.BattleGround();
            Console.WriteLine(bg.ToString());
            bg.Fight();
            Console.WriteLine(bg.ToString());
            #endregion

        }
    }
}
