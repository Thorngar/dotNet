using System;

namespace POOFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne Antonio = new Personne("Lopez", "Antonio", 300);
            Personne Louise = new Personne("Gintana", "Louise");

            // Antonio.VirementVersCompteCourant(100, Louise.GetCompteCourant); GetCompteCourant à créer pour avoir les informations de Louise 
            Antonio.AjouterArgentCompteCourant(300);
            Antonio.RetirerArgentCompteEpargne(1000);

            Console.WriteLine(Antonio.GetInfosPersonne());
        }
    }
}
