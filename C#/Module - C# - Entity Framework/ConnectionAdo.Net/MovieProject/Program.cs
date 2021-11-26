namespace MovieProject
{
	using System;
    using System.Data;
	using System.Data.SqlClient;
	class Program
	{
		const string ConnectionString = @"Server=D-W10-YOKO02\FORMATION;Database=ConnectionAdo; Trusted_Connection=True;";
		static void Main(string[] args)
		{
			int menuChoice;
			bool isClosingApp = false;

            while (true)
            {
                DisplayMenu();

                menuChoice = Int32.Parse(Console.ReadLine());

				switch (menuChoice)
                {
                    case 1:
						Console.WriteLine("Entrez le nom du film :");
	                    string name = Console.ReadLine();

                        Console.WriteLine("Entrez l'année du film :");
                        int year = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Le film était bon ? Entrez True ou False");
                        bool isGood = Boolean.Parse(Console.ReadLine());

						InsertMovie(name, year, isGood);

                        break;
                    case 2:
						Console.WriteLine("Entrez l'ID du film à supprimer :");

                        int movieId = Int32.Parse(Console.ReadLine());

                        DeleteMovie(movieId);

                        break;
                    case 3:
						Console.WriteLine("------------------");
						Console.WriteLine("Liste des films :");
                        Console.WriteLine("------------------" + "\n");

                        DisplayMovies();

						break;
                    case 0:
						isClosingApp = true;
						break;
                }

				if (isClosingApp)
                {
					break;
                }
            }
        }

        static void DisplayMenu()
		{
			Console.Clear();

			Console.WriteLine("--------------");
			Console.WriteLine("Menu des films");
			Console.WriteLine("--------------" + "\n");

			Console.WriteLine("1 - Ajouter un film");
			Console.WriteLine("2 - Supprimer un film");
			Console.WriteLine("3 - Afficher la liste des films");
			Console.WriteLine("0 - Quitter le menu");
        }

        static void DisplayMovies()
        {
            const string SqlSelect = "SELECT * FROM Movie";

            using var connection = new SqlConnection(ConnectionString);
            using var command = new SqlCommand(SqlSelect, connection);

            connection.Open();

            using var reader = command.ExecuteReader();

			while (reader.Read())
            {
				if (reader.IsDBNull("Year"))
                {
					Console.WriteLine($"ID : {reader.GetInt32("Id")} - {reader.GetString("Name")} - NULL - {reader.GetBoolean("IsGood")}");
                }
				else
                {
					Console.WriteLine($"ID : {reader.GetInt32("Id")} - {reader.GetString("Name")} - {reader.GetInt32("Year")} - {reader.GetBoolean("IsGood")}");
				}
            }

			Console.ReadLine();
        }

        static void DeleteMovie(int movieId)
		{
			if (string.IsNullOrWhiteSpace(ConnectionString))
            {
				throw new ArgumentNullException(nameof(ConnectionString));
            }

			using var connection = new SqlConnection(ConnectionString);

			using var query = new SqlCommand("DELETE FROM Movie WHERE Id = @id", connection);
            query.Parameters.Add("@id", SqlDbType.Int);
			query.Parameters["@id"].Value = movieId;

            connection.Open();

			query.ExecuteNonQuery();

			Console.ReadLine();
		}

        static void InsertMovie(string Name, int Year, bool IsGood)
		{
			const string SqlInsert = "INSERT INTO Movie(Name, Year, IsGood)" +
						 "VALUES (@name, @year, @isGood)";

			using var Connection = new SqlConnection(ConnectionString);
			using var Command = new SqlCommand(SqlInsert, Connection);

			Command.Parameters.Add("@name", SqlDbType.NVarChar);
			Command.Parameters.Add("@year", SqlDbType.Int);
			Command.Parameters.Add("@isGood", SqlDbType.Bit);

			Command.Parameters["@name"].Value = Name;
			Command.Parameters["@year"].Value = Year;
			Command.Parameters["@isGood"].Value = IsGood;

            Connection.Open();
			Command.ExecuteNonQuery();

			Console.ReadLine();
		}

    }
}

/* 

Créer une table dans la DB ConnectionAdo

Elle s'appelera : 

	- Movie
	- VALUES :

		-ID Autoincrement
		- Nom 150 CHAR
		- Année de sortie du Film
		- Si le film est bien ou pas (bool)

Programme console qui permet :

	- Inserer une film
	- Afficher la liste des films
	- Supprimer un film

*/
