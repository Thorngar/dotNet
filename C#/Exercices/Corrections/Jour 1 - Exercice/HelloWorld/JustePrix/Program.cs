using System;

namespace JustePrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Trouvez le juste prix");

            int JustePrix = random.Next(1,10);
            int PrixEntre;

            do
            {
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
                }
            } while (PrixEntre != JustePrix);
        }
    }
}
