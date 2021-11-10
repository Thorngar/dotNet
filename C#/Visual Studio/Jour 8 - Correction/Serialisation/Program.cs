using System;
using System.Collections.Generic;
using Serialisation.JSON;

namespace Serialisation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Barbecue> barbecues = new List<Barbecue>();
            
            Barbecue barbecue = new Barbecue{
                Puissance = 800,
                Marque = "Weber"
            };

            Barbecue barbecue2 = new Barbecue("weber2", 800, 600);

            barbecues.Add(barbecue);
            barbecues.Add(barbecue2);

            ReadAndWriteJSON.WriteToJsonFile(@"C:\Users\s_11083_devnet\Desktop\barbecue.json", barbecues);

            List<Barbecue> b2 = ReadAndWriteJSON.ReadFromJsonFile<List<Barbecue>>(@"C:\Users\s_11083_devnet\Desktop\barbecue.json");

            foreach(Barbecue b in b2)
            {
                Console.WriteLine(b.ToString());
            }


        }
    }
}
