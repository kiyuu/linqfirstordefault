using System;
using static Linq.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var predicate = new Predicate<int>(Predicate);


            var source = new int[4] { 1, 2, 3, 9 };
            var i = FirstOrDefault(source, predicate);

            Console.WriteLine($"i = {i}");
            Console.ReadLine();
        }

        static bool Predicate(int element)
        {
            return element == 9;
        }
    }
}
