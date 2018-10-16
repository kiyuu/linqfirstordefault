using System;
using static Linq.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var source = new int[4] { 1, 2, 3, 9 };
            //var i = FirstOrDefault(source, delegate (int element) { return element == 9; });
            //var i = FirstOrDefault(source, (int element) => { return element == 9; });
            //var i = FirstOrDefault(source, (element) => { return element == 9; });
            //var i = FirstOrDefault(source, (element) => element == 9);
            var i = FirstOrDefault(source, e => e == 9);

            Console.WriteLine($"i = {i}");
            Console.ReadLine();
        }

    }
}
