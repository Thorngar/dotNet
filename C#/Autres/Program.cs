using System;

namespace Autres
{
    /// <summary>
    /// Ma classe Program appelle une méthode Main qui affiche le texte Hello World
    /// </summary>
    class Program
    {
        /// <summary>
        /// Méthode Main qui retourne un Hello World en console.
        /// <seealso cref="System.Console.WriteLine"/>
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Inscrire votre nom : ");
            string nom = Console.ReadLine();

            Console.WriteLine("Inscrire votre prénom : ");
            string prenom = Console.ReadLine();

            int ageTypeNumber = -1;
            string age;

            while (ageTypeNumber < 0 || ageTypeNumber > 100)
            {
                Console.WriteLine("Votre age : ");
                age = Console.ReadLine();
                ageTypeNumber = Int32.Parse(age); // int32 = pour un entier // .Parse = int en string
            }

            Console.WriteLine("Nom : {0} \nPrénom: {1} \nAge: {2}", nom, prenom, ageTypeNumber);
            Console.WriteLine("Appuyez sur une touche pour fermer le terminal");
            Console.ReadKey();


            // try 
            // {
            //     Console.WriteLine(args [0]);
            // } 
            // catch(Exception e)
            // {
            //     Console.WriteLine(e.StackTrace);
            // }
            // var test = "Hello World !";
            // Console.WriteLine(test);

                        
            // Console.WriteLine("Inscrire votre âge : ");
            // int age = Console.Read();
            // if (age < 0 || age > 100) 
            // {
            //     Console.WriteLine("Vous ne pouvez pas rentrer de valeure négative");
            // } while (age > 0)
            //     {
            //         Console.WriteLine("Votre nom est : " + nom + "\n" + "Votre prénom est : " + prenom + "\n" + "Votre âge est de " + age + " ans");
            //         break;
            //     } 
            // Console.WriteLine("Appuyez sur une touche pour fermer le terminal");
            // Console.ReadKey();
        }
    }
}
