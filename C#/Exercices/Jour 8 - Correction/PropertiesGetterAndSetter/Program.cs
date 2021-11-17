using System;

namespace PropertiesGetterAndSetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne p = new Personne("Rodriguo", "Lopez", 50);

            Console.WriteLine(p.Nom);
        }
    }
}
