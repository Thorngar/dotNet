using System;
using System.IO;

namespace Serialisation
{
    class ReadInFile
    {
        public static void ReadFileTxt()
        {
            string text = File.ReadAllText(@"C:\Users\s_11083_devnet\source\repos\Module7\Serialisation\bin\Debug\net5.0\WriteLines.txt");

            // Display the file contents to the console. Variable text is a string.
            System.Console.WriteLine("Contents of WriteLines.txt = {0}", text);
        }

        public static void ReadFileArrayTxt()
        {
            string[] lines = File.ReadAllLines(@"C:\Users\s_11083_devnet\source\repos\Module7\Serialisation\bin\Debug\net5.0\WriteLines.txt");

            // Display the file contents by using a foreach loop.
            System.Console.WriteLine("Contents of WriteLines.txt = ");
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
            }
        }
    }
}
