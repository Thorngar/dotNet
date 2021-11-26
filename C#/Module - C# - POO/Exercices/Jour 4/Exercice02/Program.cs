using System;

namespace Exercice02
{
    class Program
    {
        static void Main(string[] args)
        {
            IMusicien Musicien = new JoueurDeViolon();
            Musicien.JoueUnInstrument();
        }
    }
}
