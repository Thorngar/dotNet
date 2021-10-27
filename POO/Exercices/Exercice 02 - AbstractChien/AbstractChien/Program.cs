using System;

namespace AbstractChien
{
    class Program
    {
        static void Main(string[] args)
        {
            BergerAllemand bAllemand1 = new BergerAllemand();
            BergerAustralien bAustralien1 = new BergerAustralien();

            Console.WriteLine(bAllemand1.Aboyer());
            Console.WriteLine(bAustralien1.Aboyer());

            bAllemand1.Vieillir();
            bAllemand1.Vieillir();

            bAustralien1.Vieillir();

            Console.WriteLine(bAllemand1.GetInfo());
            Console.WriteLine(bAustralien1.GetInfo());
        }
    }
}
