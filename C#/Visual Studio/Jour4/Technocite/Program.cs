using System;

namespace Technocite
{
    class Program
    {
        static void Main(string[] args)
        {
            // Formateurs
            Formateur formateur1 = new Formateur("Antonio", "Lopez", SujetEnum.Anglais);
            Formateur formateur2 = new Formateur("Lucas", "Lopez");

            // Modules
            Module module1 = new Module(32, formateur1, SujetEnum.Git);
            Module module2 = new Module(64, formateur1, SujetEnum.Anglais);
            Module module3 = new Module(12, formateur2, SujetEnum.Html);

            Console.WriteLine(module1);
            Console.WriteLine(module2);
            

            /*
            // Eleves
            Eleve eleve1 = new Eleve("Marco", "Polo", 18);
            Eleve eleve2 = new Eleve("Rico", "Polo", 22);

            // Ajout des modules
            eleve1.AjouterUnModule(module1);
            eleve1.AjouterUnModule(module3);

            eleve2.AjouterUnModule(module2);
            eleve2.AjouterUnModule(module3);

            // Retirer des modules
            // eleve1.RetirerUnModule(module3);

            Console.WriteLine(eleve1);
            Console.WriteLine(eleve2);
            */
        }
    }
}
