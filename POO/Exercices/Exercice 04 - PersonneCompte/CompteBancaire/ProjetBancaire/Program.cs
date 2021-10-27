using System;

namespace ProjetBancaire
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Personne01 = new Person(2199, 999, "Roger ","Laminari ");
            Console.WriteLine(Personne01.GetInfo());
        }
    }
}
