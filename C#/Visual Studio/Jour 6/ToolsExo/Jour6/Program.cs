using System;

namespace Jour6
{
    class Program
    {
        static void Main(string[] args)
        {
            int MainMenuChoice;
            bool IsClosingApp = true;
            Hammer Marteau1 = new Hammer(40);
            Screwdriver Visseuse = new Screwdriver(40);

            Character bricoleur = new Character("Henri", "Dupont", Marteau1);
            Character bricoleur2 = new Character("Henriette", "Dupont", Visseuse);

            while (true)
            {
                DisplayMenu();
                MainMenuChoice = Int32.Parse(Console.ReadLine());

                switch (MainMenuChoice)
                {
                    case 1:
                        DisplayBricoMenu(bricoleur);
                        break;
                    case 2:
                        DisplayToolMenu(bricoleur);
                        break;   
                    case 3:
                        DisplayBricoleur(bricoleur);
                        break;
                    case 0:
                        IsClosingApp = true;
                        break;
                }

                if (IsClosingApp)
                {
                    break;
                }
            }

            /*            do
                        {
                            bricoleur2.ToHit(bricoleur);
                            bricoleur.ToHit(bricoleur2);
                            Console.WriteLine(bricoleur.ToString());
                            Console.WriteLine(bricoleur2.ToString());
                        } while (bricoleur.GetLife() > 0 && bricoleur2.GetLife() > 0);*/


            /*
                        bricoleur.AddTool(Marteau1);
                        bricoleur.AddTool(Marteau2);
                        Console.WriteLine(bricoleur.GetTool());*/

        }

        public static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("===============");
            Console.WriteLine("Le Brico Battle");
            Console.WriteLine("===============");

            Console.WriteLine("1 - Créer ton bricoleur");
            Console.WriteLine("2 - Ajouter un outil");
            Console.WriteLine("3 - Afficher les bricoleurs");
            Console.WriteLine("0 - Fermer");
        }

        public static void DisplayBricoMenu(Character character)
        {
            Console.Clear();
            Console.WriteLine("=============");
            Console.WriteLine("Menu d'ajout");
            Console.WriteLine("=============");

            Console.WriteLine("Entrez un nom");
            string nom = Console.ReadLine();

            Console.WriteLine("Entrez un prenom");
            string prenom = Console.ReadLine();

            Character c = new Character(nom, prenom);
        }

        public static void DisplayToolMenu(Character character)
        {
            Console.Clear();
            Console.WriteLine("=============");
            Console.WriteLine("Menu d'ajout");
            Console.WriteLine("=============");

            Console.WriteLine("Voulez-vous ajouter un outil ? o/n");

        }

        public static void DisplayBricoleur(Character character)
        {
            Console.WriteLine(character.ToString());
        }
    }
}
