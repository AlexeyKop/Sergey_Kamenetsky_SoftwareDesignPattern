using System;
using System.Text;
using static System.Console;

namespace StringIntern
{
    class Program
    {
        public static void Main()
        {
            // Видео https://youtu.be/mZ7OnzlSth0

            // Статья https://docs.microsoft.com/ru-ru/dotnet/api/system.string.intern?view=net-5.0
            string s1 = "Катя ела кашу";
            string s2 = new StringBuilder().Append("Катя ").Append("ела кашу").ToString();
            string s3 = String.Intern(s2);
            WriteLine($"s1 == {s1}"); // s1 == Катя ела кашу
            WriteLine($"s2 == {s2}"); // s2 == Катя ела кашу
            WriteLine($"s3 == {s3}"); // s3 == Катя ела кашу
            WriteLine($"s2 == s1?: {(Object)s2 == (Object)s1}"); // s2 == s1?: False
            WriteLine($"s3 == s1?: {(Object)s3 == (Object)s1}"); // s3 == s1?: True

            string s4 = "Катя ела кашу";
            WriteLine($"s4 == s1?: {(Object)s4 == (Object)s1}"); // s4 == s1?: True  

            string s5 = s1;
            WriteLine($"s5 == s1?: {(Object)s5 == (Object)s1}"); // s5 == s1?: True  

            WriteLine(s1.GetHashCode()); // 479298570
            WriteLine(s2.GetHashCode()); // 479298570
            WriteLine(s3.GetHashCode()); // 479298570
            WriteLine(s4.GetHashCode()); // 479298570
            WriteLine(s5.GetHashCode()); // 479298570


        }
    }
}