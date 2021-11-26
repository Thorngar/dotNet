using System;

namespace JustePrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Random = new Random();
            Console.WriteLine("Trouvez le juste prix");

            int JustePrix = Random.Next(1, 10);
            int PrixEntre;

            do
            { }
                PrixEntre = Int32.Parse(Console.ReadLine());

                if (PrixEntre < JustePrix)
                {
                    Console.WriteLine("C'est plus");
                }
                else if (PrixEntre > JustePrix)
                {
                    Console.WriteLine("C'est moins");
                }
                else if (PrixEntre == JustePrix)
                {
                    Console.WriteLine("C'est le juste prix");
                } while (PrixEntre != JustePrix) ;
            
            
        }
    }
}



               /*         int Number;

            Console.WriteLine("=======================");
            Console.WriteLine("Le Juste Prix du Pauvre");
            Console.WriteLine("======================="+"\n");
            Console.WriteLine("Entrez un nombre entre 1 et 200 :");
            Number = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Vous proposez le chiffre " + Number);

            while (Number != 1) 
            {
                Console.WriteLine("Mauvais choix !");
                Console.WriteLine("Entrez un nombre :");
                Number = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("Bien joué, vous avez trouvé le bon chiffre"); */

