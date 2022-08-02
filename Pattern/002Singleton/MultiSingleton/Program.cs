using System;
using System.Data.Common;
using System.Runtime.CompilerServices;

namespace MultiSingleton
{

    class Program
    {
        static void Main(string[] args)
        {
            Singleton.Max = 5;

            Console.WriteLine($"OtherSingleton.Max = {Singleton.Max}");
            
            Singleton.WorkingIndex = 1;
            Console.WriteLine($"OtherSingleton.WorkingIndex {Singleton.WorkingIndex }");
            Console.WriteLine($"Data = {Singleton.Instance.Data}");

            Singleton.Instance.Data = 2025;

            Singleton.WorkingIndex = 1;
            Console.WriteLine($"OtherSingleton.WorkingIndex {Singleton.WorkingIndex }");
            Console.WriteLine($"Data = {Singleton.Instance.Data}");



            Singleton.WorkingIndex = 3;
            Console.WriteLine($"OtherSingleton.WorkingIndex {Singleton.WorkingIndex }");
            Console.WriteLine($"Data = {Singleton.Instance.Data}");
            Console.WriteLine();
            
            
            Singleton.Max = 15;
            Console.WriteLine($"OtherSingleton.Max = {Singleton.Max}");

            Singleton.WorkingIndex = 10;
            Console.WriteLine($"OtherSingleton.WorkingIndex {Singleton.WorkingIndex}");
            Console.WriteLine($"Data = {Singleton.Instance.Data}");

            Singleton.Instance.Data = 2030;

            Console.WriteLine($"OtherSingleton.WorkingIndex {Singleton.WorkingIndex}");
            Console.WriteLine($"Data = {Singleton.Instance.Data}");


            Singleton.WorkingIndex = 1;
            Console.WriteLine($"OtherSingleton.WorkingIndex {Singleton.WorkingIndex }");
            Console.WriteLine($"Data = {Singleton.Instance.Data}");

            Console.WriteLine();
            Singleton.Max = 25;
            Console.WriteLine($"OtherSingleton.Max = {Singleton.Max}");

            Singleton.WorkingIndex = 10;
            Console.WriteLine($"OtherSingleton.WorkingIndex {Singleton.WorkingIndex}");
            Console.WriteLine($"Data = {Singleton.Instance.Data}");

            Singleton.WorkingIndex = 1;
            Console.WriteLine($"OtherSingleton.WorkingIndex {Singleton.WorkingIndex }");
            Console.WriteLine($"Data = {Singleton.Instance.Data}");






            Console.ReadKey(); 
        }
    }
}
