using System;
using static Linq.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = new int[4] { 1, 2, 3, 9 }.FirstOrDefault(e => e == 9);
            var f = new int[4] { 1, 2, 3, 9 }.FirstOrDefault();

            Console.WriteLine($"i = {i}");
            Console.ReadLine();
        }

    }
}
