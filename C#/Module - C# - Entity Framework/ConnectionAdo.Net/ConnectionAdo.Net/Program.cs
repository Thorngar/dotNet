using System;
using System.Data;
using System.Data.SqlClient;

namespace ConnectionAdo.Net
{
	class Program
	{
		static void Main(string[] args)
		{
			const string ConnectionString = @"Server=D-W10-YOKO02\FORMATION;Database=ConnectionAdo; Trusted_Connection=True;";
			// @ ici permet de mettre des \ au lieu de \\ pour les chemins

			Console.WriteLine("Avant insertion");

			ReadData(ConnectionString);
			InsertData(ConnectionString);

			Console.WriteLine();

			Console.WriteLine("Après insertion");
			ReadData(ConnectionString);
		}

		static void InsertData(string ConnectionString)
		{
			const string SqlInsert = "INSERT INTO Person(Name, Active, DateOfBirth)" +
									 "VALUES (@name, @active, @date)";

			using var Connection = new SqlConnection(ConnectionString);
			using var Command = new SqlCommand(SqlInsert, Connection);

			Command.Parameters.Add("@name", SqlDbType.VarChar).Value = "Dark";
			Command.Parameters.Add("@active", SqlDbType.Bit).Value = 1;
			Command.Parameters.Add("@date", SqlDbType.DateTime2).Value = DateTime.UtcNow;

			Connection.Open();
			Command.ExecuteNonQuery();
		}

		static void ReadData(string ConnectionString)
		{
			using (var Connection = new SqlConnection(ConnectionString))
			{
				const string SqlSelect = "SELECT * FROM Person";

				using (var Command = new SqlCommand(SqlSelect, Connection))
				{
					Connection.Open();
					using (var Reader = Command.ExecuteReader())
					{
						while (Reader.Read())
						{
							if (Reader.IsDBNull(3))
							{
								Console.WriteLine($" ID : {Reader.GetInt32("Id")} - {Reader.GetString("Name")} - {Reader.GetBoolean("Active")} - NULL");
							}
							else
							{
								Console.WriteLine($" ID : {Reader.GetInt32("Id")} - {Reader.GetString("Name")} - {Reader.GetBoolean("Active")} - {Reader.GetDateTime("DateOfBirth")}");
							}
						}
					}
				}
			}
		}
	}
}

