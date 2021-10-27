using System;

namespace Exercice4PersonneCompte
{
    class Program
    {
        static void Main(string[] args)
        {
            CompteCourant CompteCourant1 = new CompteCourant(1500);
            CompteEpargne CompteEpargne1 = new CompteEpargne(2000);

            CompteCourant CompteCourant2 = new CompteCourant(1000);
            CompteEpargne CompteEpargne2 = new CompteEpargne(3000);

            // CompteCourant1.Deposer(100);
            // CompteEpargne1.Retirer(1000);

            // CompteCourant1.TransfertCourantEpargne(100, CompteEpargne1, CompteCourant1);
            
            Personne Personne1 = new Personne("Sardou", "Michel", CompteCourant1, CompteEpargne1);
            Personne Personne2 = new Personne("Mokka", "Linda", CompteCourant2, CompteEpargne2);

            Personne Personne = new Personne();
            Personne.TransfertBetweenAccount(750, CompteCourant1, CompteCourant2); // Transfert entre les deux comptes courants
            Console.WriteLine(Personne1.GetInfos());
            Console.WriteLine(Personne2.GetInfos());
        }
    }
}
