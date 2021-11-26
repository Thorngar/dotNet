using System;

namespace Exercice05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Tableau = new int[5];
            int Compteur = 0;

            Console.WriteLine("Entrez une note");
            for (int i = 0; i < 5; i++)
            {
                Tableau[i] = Int32.Parse(Console.ReadLine());
                if (Tableau[i] > 10)
                {
                    Compteur++;
                }
            }

            int[] SortedValue = new int[Compteur];
            Compteur = 0;

            for (int i = 0; i < 5; i++)
            {
                if (Tableau[i] > 10)
                {
                    SortedValue[Compteur] = Tableau[i];
                    Compteur++;
                }
            }

            Console.WriteLine("Toutes les notes : ");
            displayList(Tableau);

            Console.WriteLine("Notes retenues : ");
            displayList(SortedValue);

            static void displayList(int[] myList)
            {
                foreach (int myInt in myList)
                {
                    Console.Write(myInt + " ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
