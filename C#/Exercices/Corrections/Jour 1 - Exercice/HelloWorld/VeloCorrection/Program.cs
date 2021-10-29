using System;

namespace VeloCorrection
{
    class Program
    {
        static void Main(string[] args)
        {
            Velo velo1 = GenerateNewVelo();

            velo1.VendreVelo();

            Console.WriteLine(velo1.ToString());
        }

        public static Velo GenerateNewVelo()
        {
            Console.WriteLine("Entrez une marque de vélo: ");
            string Marque = Console.ReadLine();

            Console.WriteLine("Entrez un prix: ");
            int Prix = Int32.Parse(Console.ReadLine());

            return new Velo(Marque, Prix);
        }
    }
}
