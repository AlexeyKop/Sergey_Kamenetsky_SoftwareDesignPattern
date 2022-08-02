using System;

namespace LazySingleton
{

    class Program
    {
        static void Main(string[] args)
        {
            var item1 = Singleton.Instance;
            var item2 = Singleton.Instance;

            item1.Data = 289;
            
            //item1.GetHashCode() 58225482  289
            Console.WriteLine($"item1.GetHashCode() {item1.GetHashCode()}  {item1.Data}");


            //item2.GetHashCode() 58225482  289
            Console.WriteLine($"item2.GetHashCode() {item2.GetHashCode()}  {item2.Data}");

        }
    }
}
