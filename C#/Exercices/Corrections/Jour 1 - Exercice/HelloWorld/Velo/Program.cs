using System;

namespace Velo
{
    class Program
    {
        static void Main(string[] args)
        {
            Velo velo1 = GenerateNewVelo();

            velo1.VendreVelo();

            Console.WriteLine(velo1.ToString());
        }

        static Velo GenerateNewVelo()
        {
            Console.WriteLine("Entrez la marque du vélo: ");
            string Marque = Console.ReadLine();
            Console.WriteLine("Entrez le prix du vélo: ");
            int Prix = Int32.Parse(Console.ReadLine());

            return new Velo(Marque, Prix);
        }
    }
}
