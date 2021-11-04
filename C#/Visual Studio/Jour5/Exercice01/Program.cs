using System;

namespace Exercice01
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipe Equipe = new Equipe("Equipe u-18");
            Joueur j1 = new Joueur("Lopez", "Lucas", 16, 1);
            Joueur j2 = new Joueur("Dirk", "Frimout", 17, 2);
            
            bool WantMenu = true;

            while (WantMenu)
            {
                DisplayMenu();
                string Touche = Console.ReadLine();
                int NombrePresse = Int32.Parse(Touche);

                while (NombrePresse < 1 || NombrePresse > 2)
                {
                    DisplayMenu();
                    Touche = Console.ReadLine();
                    NombrePresse = Int32.Parse(Touche);
                }

                switch (NombrePresse)
                {
                    case 1:
                        Console.WriteLine("Veuillez entrer un numéro : ");
                        int Numero1 = Int32.Parse(Console.ReadLine());
                        Equipe.AjouterUnJoueur(j1);
                        break;
                    case 2:
                        Console.WriteLine("Veuillez entrer un numéro : ");
                        int Numero2 = Int32.Parse(Console.ReadLine());
                        Equipe.SupprimerUnJoueurParNumero(Numero2);
                        Console.WriteLine(Equipe.ToString());
                        break;
                }

                Console.WriteLine("Faire un nouvel ajout/retrait ? (oui/non)");
                string InputNewJoueur = Console.ReadLine();

                if (InputNewJoueur.ToLower().Equals("oui"))
                {
                    WantMenu = true;
                }
                else
                {
                    WantMenu = false;
                }
            }
        }

        static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("==============================");
            Console.WriteLine("Ajouter ou supprimer un joueur");
            Console.WriteLine("==============================");
            Console.WriteLine("1- Ajouter un joueur");
            Console.WriteLine("2- Supprimer un joueur");
        }
    }
}
