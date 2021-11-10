using System;

namespace PropertiesGetterSetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne p = new Personne("Rodriguo", "Lopez", 50);

            Console.WriteLine(p.NomProperty);
        }
    }
}
