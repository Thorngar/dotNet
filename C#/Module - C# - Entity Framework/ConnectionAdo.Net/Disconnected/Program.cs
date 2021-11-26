using System;
using System.Data;
using System.Data.SqlClient;

namespace Disconnected
{
    class Program
    {
        const string connectionString = @"Server=D-W10-YOKO02\FORMATION;Database=ConnectionAdo; Trusted_Connection=True;";

        static void Main(string[] args)
        {
            SelectData();
            UpdateData();
		}

        private static void UpdateData()
        {
            const string sqlSelect = "SELECT * FROM Person";

            var data = new DataSet();

            using (var connection = new SqlConnection(connectionString))
            {
                using (var commandSelect = new SqlCommand(sqlSelect, connection))
                {
                    var adapter = new SqlDataAdapter();

                    adapter.SelectCommand = commandSelect;
                    adapter.Fill(data, "Person");
                }
            }

            data.Tables["Person"].Rows[0].BeginEdit();
            data.Tables["Person"].Rows[0]["Name"] = "toto";
            data.Tables["Person"].Rows[0].EndEdit();

            using (var connection = new SqlConnection(connectionString))
            {
                using (var commandSelect = new SqlCommand(sqlSelect, connection))
                {
                    var adapter = new SqlDataAdapter();
                    adapter.SelectCommand = commandSelect;

                    var commandBuilder = new SqlCommandBuilder(adapter);
                    commandBuilder.GetUpdateCommand();

                    adapter.SelectCommand = commandSelect;
                    adapter.Update(data.Tables["Person"]);
                }
            }
        }

        private static void DeleteData()
        {
            const string sqlSelect = "SELECT * FROM Person";

            var data = new DataSet();

            using (var connection = new SqlConnection(connectionString))
            {
                using (var commandSelect = new SqlCommand(sqlSelect, connection))
                {
                    var adapter = new SqlDataAdapter();
                    adapter.SelectCommand = commandSelect;
                    adapter.Fill(data, "Person");
                }
            }

            data.Tables["Person"].Rows[0].Delete();

            using (var connection = new SqlConnection(connectionString))
            {
                using (var commandSelect = new SqlCommand(sqlSelect, connection))
                {
                    var adapter = new SqlDataAdapter();
                    adapter.SelectCommand = commandSelect;

                    var commandBuilder = new SqlCommandBuilder(adapter);
                    commandBuilder.GetDeleteCommand();

                    adapter.Update(data.Tables["Person"]);
				}
			}
		}

		private static void SelectData()
        {
            const string sqlSelect = "SELECT * FROM Person";

            var data = new DataSet();

            using (var connection = new SqlConnection(connectionString))
            {
                using (var commandSelect = new SqlCommand(sqlSelect, connection))
                {
                    var adapter = new SqlDataAdapter();
                    adapter.SelectCommand = commandSelect;
                    adapter.Fill(data, "Person");
                }
            }

            foreach (DataColumn column in data.Tables["Person"].Columns)
            {
                Console.Write("{0, 10} ", column.ColumnName);
            }

            Console.WriteLine();

            foreach (DataRow item in data.Tables["Person"].Rows)
            {
                Console.WriteLine(
                                   "{0, 10} {1, 10} {2, 10} {3, 10:dd/MM/yyyy}",
                                   item["Id"],
                                   item["Name"],
                                   item["Active"],
                                   item["DateOfBirth"]
                                  );
            }
        }
    }
}
