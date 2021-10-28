using System;

namespace ProjetSomme
{
    class Program
    {
        static void Main(string[] args)
        {

            // int a, b;

            // Console.WriteLine("Insérez votre premier nombre : ");
            // a = int.Parse(Console.ReadLine());
            // Console.WriteLine("Insérez votre deuxième nombre : ");
            // b = int.Parse(Console.ReadLine());
            // var c = a + b ;
            // Console.WriteLine("Le résultat de la somme est : " + c);
            
            Console.WriteLine("===================");
            Console.WriteLine("Programme de calcul");
            Console.WriteLine("===================");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Soustraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            int ChoixMenu = Int32.Parse(Console.ReadLine());


            Console.WriteLine("Entrez votre premier nombre : ");
            int FirstNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Entrez votre deuxième nombre : ");
            int SecondNumber = Int32.Parse(Console.ReadLine());

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

            // Console.WriteLine("Résultat : ");
            // Console.WriteLine(Addition(FirstNumber, SecondNumber));
        }
        static int Addition(int FirstNumber, int SecondNumber)
        {
            return FirstNumber + SecondNumber;
        }
        static int Soustraction(int FirstNumber, int SecondNumber)
        {
            return FirstNumber - SecondNumber;
        }
        static int Multiplication(int FirstNumber, int SecondNumber)
        {
            return FirstNumber * SecondNumber;
        }
        static double Division(double FirstNumber, double SecondNumber)
        {
            return FirstNumber / SecondNumber;
        }
    }
}
