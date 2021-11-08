using System;

namespace SommeProjectCorrection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================");
            Console.WriteLine("Programme de calcul");
            Console.WriteLine("====================");
            Console.WriteLine("1- Addition");
            Console.WriteLine("2- Soustraction");
            Console.WriteLine("3- Multiplication");
            Console.WriteLine("4- Division");

            int ChoixMenu = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Entrez un 1er nombre:");
            int FirstNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Entrez un 2eme nombre:");
            int SecondNumber = Int32.Parse(Console.ReadLine());


            do
            {
                // CODE
            } while (true)

            switch (ChoixMenu)
            {
                case 1:
                    Console.WriteLine(FirstNumber + "+" + SecondNumber + "=" + Addition(FirstNumber, SecondNumber));
                    break;
                case 2:
                    Console.WriteLine(FirstNumber + "-" + SecondNumber + "=" + Soustraction(FirstNumber, SecondNumber));
                    break;
                case 3:
                    Console.WriteLine(FirstNumber + "*" + SecondNumber + "=" + Multiplication(FirstNumber, SecondNumber));
                    break;
                case 4:
                    Console.WriteLine(FirstNumber + "/" + SecondNumber + "=" + Division(FirstNumber, SecondNumber));
                    break;
            }



        }

        private static int Soustraction(int FirstNumber, int SecondNumber)
        {
            return FirstNumber - SecondNumber;
        }

        static int Addition(int FirstNumber, int SecondNumber)
        {
            return FirstNumber + SecondNumber;
        }

        private static int Multiplication(int FirstNumber, int SecondNumber)
        {
            return FirstNumber * SecondNumber;
        }

        private static double Division(double FirstNumber, double SecondNumber)
        {
            return FirstNumber / SecondNumber;
        }
    }
}
