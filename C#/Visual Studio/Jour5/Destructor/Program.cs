using System;

namespace Destructor
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Destructor Essai = new Destructor())
            {
                Console.WriteLine(Essai);
                GC.SuppressFinalize(Essai);
            }

        }
    }
}
