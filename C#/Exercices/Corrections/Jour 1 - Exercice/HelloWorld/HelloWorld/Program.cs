using System;

namespace HelloWorld
{
	/// <summary>
	///	Ma classe Program appelle une méthode Main qui affiche le texte Hello World.
	/// </summary>
	class Program
	{
		/// <summary>
		/// Méthode Main qui retourne un hello world en console.
		/// <seealso cref="System.Console.WriteLine"/>
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			Console.WriteLine("Votre nom:");
			string nom = Console.ReadLine();			
			
			Console.WriteLine("Votre prenom:");
			string prenom = Console.ReadLine();

			int ageTypeNumber = -1;
			string age;

			while (ageTypeNumber < 0 || ageTypeNumber > 100)
			{
				Console.WriteLine("Votre age:");
				age = Console.ReadLine();
				ageTypeNumber = Int32.Parse(age);
			}

			Console.WriteLine("Nom: {0} \nPrénom: {1} \nAge: {2}", nom, prenom, ageTypeNumber);

			Console.WriteLine("Appuyez sur une touche pour fermer le terminal");
			Console.ReadKey();
		}
	}
}
