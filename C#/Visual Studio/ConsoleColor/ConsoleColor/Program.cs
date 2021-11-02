using System;

namespace ConsoleColor
{
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

        }
    }
