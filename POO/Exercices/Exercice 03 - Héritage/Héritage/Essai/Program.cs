using System;

namespace Essai
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Employee2 = new Employee("Patrov", "Robert", 9);
            Console.WriteLine(Employee2.GetInfos());
        }
    }
}