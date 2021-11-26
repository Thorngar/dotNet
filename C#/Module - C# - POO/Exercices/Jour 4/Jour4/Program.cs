using System;
using System.Collections.Generic; // permet d'initialiser les listes
using Jour4.PersonnalException; // permet de catch l'erreur âge

namespace Jour4
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipe Equipe = new Equipe("Equipe u-18");
            Joueur j1 = new Joueur("Lopez", "Lucas", 20, 1);
            Joueur j2 = new Joueur("Dirk", "Frimout", 17, 1);

            try
            {
                Equipe.AjouterUnJoueur(j1);
                Equipe.AjouterUnJoueur(j2);
            }
            catch (AgeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}    


