using System;
using static System.Console;
using System.Linq;

namespace Iterator
{

    class Program
    {
        static void Main()
        {
            SimpleSet<int> set = new(Enumerable.Range(1,10));
            foreach (var item in set) Write($"{item} ");
        }
    }
}
