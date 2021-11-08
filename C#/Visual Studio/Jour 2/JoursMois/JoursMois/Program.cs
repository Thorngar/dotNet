using System;

namespace JoursMois
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez rentrer un nombre entre 1 et 365");
            int Number = int.Parse(Console.ReadLine());

            while (Number < 1 || Number >365)
            {
                Console.WriteLine("Rentrez un chiffre entre 1 et 365");
                Number = Int32.Parse(Console.ReadLine());
            }

            if (Number <= 31)
            {
                Console.WriteLine("Nous sommes le " + Number + " Janvier");
            }
            else if (Number <= 59)
            {
                Console.WriteLine("Nous sommes le " + (Number - 31) + " Février");
            }
            else if (Number <= 90)
            {
                Console.WriteLine("Nous sommes le " + (Number - 59) + " Mars");
            }
            else if (Number <= 121)
            {
                Console.WriteLine("Nous sommes le " + (Number - 90) + " Avril");
            }
            else if (Number <= 151)
            {
                Console.WriteLine("Nous sommes le " + (Number - 121) + " Mai");
            }
            else if (Number <= 181)
            {
                Console.WriteLine("Nous sommes le " + (Number - 151) + " Juin");
            }
            else if (Number <= 212)
            {
                Console.WriteLine("Nous sommes le " + (Number - 181) + " Juillet");
            }
            else if (Number <= 243)
            {
                Console.WriteLine("Nous sommes le " + (Number - 212) + " Août");
            }
            else if (Number <= 273)
            {
                Console.WriteLine("Nous sommes le " + (Number - 243) + " Septembre");
            }
            else if (Number <= 304)
            {
                Console.WriteLine("Nous sommes le " + (Number - 273) + " Octobre");
            }
            else if (Number <= 334)
            {
                Console.WriteLine("Nous sommes le " + (Number - 304) + " Novembre");
            }
            else if (Number <= 365)
            {
                Console.WriteLine("Nous sommes le " + (Number - 334) + " Décembre");
            }

            Console.WriteLine("Alors heureux ? ");
            Console.WriteLine("Appuyez sur une touche pour sortir du terminal.");
            Console.ReadKey();

        }
    }
}
