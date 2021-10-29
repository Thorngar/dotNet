using System;

namespace Moyenne
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Moyenne

            int UserNumber;
            double MeanValue = 0;
            int i = 0;

            do
            {
                Console.WriteLine("Entrez un nombre : (-1 pour quitter)");
                UserNumber = Int32.Parse(Console.ReadLine());

                if (UserNumber == -1)
                {
                    break;
                }
                else
                {
                    MeanValue += UserNumber;
                    i++;
                }

            } while (true);

            Console.WriteLine("La moyenne : " + (MeanValue/i));

            #endregion
        }
    }
}
