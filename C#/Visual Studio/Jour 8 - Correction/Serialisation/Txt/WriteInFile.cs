
using System.IO;
using System.Threading.Tasks;

namespace Serialisation
{
    class WriteInFile
    {
        public static async Task ExampleAsync()
        {
            string[] lines =
            {
            "First line", "Second line"
            };

            await File.WriteAllLinesAsync("WriteLines.txt", lines);
        }
    }
}
