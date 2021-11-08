using System;

namespace Vélo
{
    class Program
    {
        static void Main(string[] args)
        {
            Vélo Vélo1 = GenerateNewVélo();

            Console.WriteLine(Vélo1.ToString());

            // Console.WriteLine("Entrez la marque de votre vélo : "); 
            // string Marque = Console.ReadLine();

            // Console.WriteLine("Entrez un prix : ");
            // int Prix = Int32.Parse(Console.ReadLine());

            // Vélo Vélo1 = new Vélo(Marque, Prix);
            // Console.WriteLine(Vélo1.ToString());
        }
        public static Vélo GenerateNewVélo()
        {
            Console.WriteLine("Entrez la marque de votre vélo : "); 
            string Marque = Console.ReadLine();

            Console.WriteLine("Entrez un prix : ");
            int Prix = Int32.Parse(Console.ReadLine());

            return new Vélo(Marque, Prix);
        }
    }

    class Vélo 
    {
        private String Marque;
        private int Prix;

        public Vélo(String Marque, int Prix)
        {
            this.Marque = Marque;
            this.Prix = Prix;
        }
        
        public override string ToString()
        {
            return "La marque du vélo est " + this.Marque + " et son prix est de " + this.Prix + " euros";
        }
    }
}
