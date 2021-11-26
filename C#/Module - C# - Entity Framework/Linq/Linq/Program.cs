namespace Linq
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            var list = new[] { 9, 5, -1, 0, 5, 10, 11 };

            Display(list);

            var a = list.Where(num => num < 5).OrderByDescending(num => num);

            /*
            var a = from num in list 
                    where num < 5 
                    orderby num 
                    select num;
            */

            Display(a);

            var b = list.Where(num => num == 5);

            /*
            var b = from num in list 
                    where num == 5 
                    select num;
            */

            Display(b);

            var c = list.Where(num => (num % 2 ==0) && (num != 0));

            /*
            var c = from num in list 
                    where (num % 2 == 0) && (num != 0) 
                    select num;
            */

            Display(c);

            Console.ReadLine();
        }

        static void Display(IEnumerable<int> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }

        /*
        static void Display(IEnumerable<int> liste)
        {

        }
        */
    }
}
