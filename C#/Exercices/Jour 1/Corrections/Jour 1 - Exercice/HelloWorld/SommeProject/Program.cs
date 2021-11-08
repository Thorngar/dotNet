using System;

namespace SommeProject
{
    /// <summary>
    /// Program performs mathematicals operations with 2 numbers.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Boolean WantNewCalcul = true;

            while (WantNewCalcul)
            {
                DisplayMenu();
                string KeyPressed = Console.ReadLine();
                int NumberPressed = Int32.Parse(KeyPressed);

                while (NumberPressed < 1 || NumberPressed > 4)
                {
                    DisplayMenu();
                    KeyPressed = Console.ReadLine();
                    NumberPressed = Int32.Parse(KeyPressed);
                }

                Console.WriteLine("Entrez le 1er nombre");
                int FirstNumber = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Entrez le 2eme nombre");
                int SecondNumber = Int32.Parse(Console.ReadLine());

                switch (NumberPressed)
                {
                    case 1:
                        Console.WriteLine(FirstNumber + " + " + SecondNumber + " = " + Addition(FirstNumber, SecondNumber));
                        break;
                    case 2:
                        Console.WriteLine(FirstNumber + " - " + SecondNumber + " = " + Soustraction(FirstNumber, SecondNumber));
                        break;
                    case 3:
                        Console.WriteLine(FirstNumber + " * " + SecondNumber + " = " + Multiplication(FirstNumber, SecondNumber));
                        break;
                    case 4:
                        Console.WriteLine(FirstNumber + " / " + SecondNumber + " = " + Division(FirstNumber, SecondNumber));
                        break;
                }

                Console.Beep();

                Console.WriteLine("Faire un nouveau calcul ? (oui/non)");
                string InputNewCalcul = Console.ReadLine();

                if (InputNewCalcul.ToLower().Equals("oui"))
                {
                    WantNewCalcul = true;
                }
                else
                {
                    WantNewCalcul = false;
                }
            }
        }

        /// <summary>
        /// Display the entire menu of mathematicals operations
        /// </summary>
        static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("====================");
            Console.WriteLine("Programme de calcul");
            Console.WriteLine("====================");
            Console.WriteLine("1- Addition");
            Console.WriteLine("2- Soustraction");
            Console.WriteLine("3- Multiplication");
            Console.WriteLine("4- Division");
        }

        /// <summary>
        /// Addition of 2 numbers.
        /// </summary>
        /// <param name="FirstNumber"></param>
        /// <param name="SecondNumber"></param>
        /// <returns></returns>
        static int Addition(int FirstNumber, int SecondNumber)
        {
            return FirstNumber + SecondNumber;
        }

        /// <summary>
        /// Soustraction of 2 numbers.
        /// </summary>
        /// <param name="FirstNumber"></param>
        /// <param name="SecondNumber"></param>
        /// <returns></returns>
        static int Soustraction(int FirstNumber, int SecondNumber)
        {
            return FirstNumber - SecondNumber;
        }

        /// <summary>
        /// Multiplication of 2 numbers.
        /// </summary>
        /// <param name="FirstNumber"></param>
        /// <param name="SecondNumber"></param>
        /// <returns></returns>
        static int Multiplication(int FirstNumber, int SecondNumber)
        {
            return FirstNumber * SecondNumber;
        }

        /// <summary>
        /// Division of 2 numbers.
        /// </summary>
        /// <param name="FirstNumber"></param>
        /// <param name="SecondNumber"></param>
        /// <returns></returns>
        static double Division(int FirstNumber, int SecondNumber)
        {
            return FirstNumber / SecondNumber;
        }

    }
}
