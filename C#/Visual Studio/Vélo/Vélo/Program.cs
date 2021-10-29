using System;

namespace Vélo
{
    class Program
    {
        static void Main(string[] args)
        {
            Program Vélo1 = GenerateNewVélo();

            Vélo1.VendreVélo();

            Console.WriteLine(Vélo1.ToString());

            // Console.WriteLine("Entrez la marque de votre vélo : "); 
            // string Marque = Console.ReadLine();

            // Console.WriteLine("Entrez un prix : ");
            // int Prix = Int32.Parse(Console.ReadLine());

            // Vélo Vélo1 = new Vélo(Marque, Prix);
            // Console.WriteLine(Vélo1.ToString());
        }
        public static Program GenerateNewVélo()
        {
            Console.WriteLine("Entrez la marque de votre vélo : ");
            string Marque = Console.ReadLine();

            Console.WriteLine("Entrez un prix : ");
            int Prix = Int32.Parse(Console.ReadLine());

            return new Program(Marque, Prix);
        }
    }

    class Program
    {
        private String Marque;
        private int Prix;
        private Boolean IsVendu;
        public Program(String Marque, int Prix)
        {
            this.Marque = Marque;
            this.Prix = Prix;
            this.IsVendu = false;
        }

        public void VendreVélo()
        {
            Random Random = new Random();
            int SecondsToWait = Random.Next(1, 10);

            Console.WriteLine("Temps de vente estimé : 10 secondes");
            Console.WriteLine("En attente ...");

            System.Threading.Thread.Sleep(SecondsToWait * 1000);

            IsVendu = true;

            Console.Beep();
            Console.WriteLine("Vélo a été vendu en " + SecondsToWait + " secondes !");
            ToString();
        }

        public override string ToString()
        {
            return "La marque du vélo est " + this.Marque + " et son prix est de " + this.Prix + " euros" + "\n" + "Vendu :" + (IsVendu ? " Oui" : " Non");
        }
    }
}
