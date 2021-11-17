using System;

namespace Exercice02
{
    class Program
    {
        static void Main(string[] args)
        {
            Voiture Voiture01 = new Voiture("Tesla");
            Conducteur Conducteur01 = new Conducteur("Pascal", "Maccino", Voiture01);
            Conducteur Conducteur02 = new Conducteur("Michelle", "Dupont", Voiture01);

            Console.WriteLine(Conducteur01.ToString());

            Conducteur01.AvancerVoiture(100);
            Conducteur02.AvancerVoiture(100);

            Console.WriteLine(Conducteur01.ToString());
        }
    }
}
