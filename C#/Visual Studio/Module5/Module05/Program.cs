using System;

namespace Exercice01
{
    class Program
    {
        static void Main(string[] args)
        {
            Barrage Barrage01 = new Barrage("Lac RIP");

            Console.WriteLine(Barrage01.ToString());

            Console.WriteLine("Appuyez sur une touche pour changer l'état de la vanne");
            Console.ReadLine();
            Barrage01.SwitchVanneState();

            Console.WriteLine(Barrage01.ToString());
        }
    }
}
