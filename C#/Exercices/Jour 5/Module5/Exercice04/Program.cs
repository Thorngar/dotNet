using System;

namespace Exercice04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] MonTableau = new int[50];
            int Compteur = 0;

/*            for (int i = 0; i < MonTableau.Length; i++)
            {
                MonTableau[i] = i;
                Console.WriteLine(i);
            }*/
    
            for (int i = MonTableau.Length-1; i >= 0; i--)
            {
                MonTableau[Compteur] = i;
                Compteur++;
            }

            displayList(MonTableau);
            Array.Sort(MonTableau);
            displayList(MonTableau);
            
/*            foreach (int valeur in MonTableau)
            {
                Console.WriteLine(valeur);
            }
*/
        }
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
