using System;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var linq = new IntWhere();
            var source = new int[4] { 1, 2, 3, 9 };
            var i = linq.FirstOrDefault(source);

            Console.WriteLine($"i = {i}");
            Console.ReadLine();
        }
    }
}
