using System;
using static System.Console;

namespace SimpleState
{
 
    class Program
    {
        static void Main()
        {
            Console.WriteLine("SimpleState.Anythink");
            var av = new SimpleState.Anythink.Variable();

            av.True();  // Значение установлено в истину
            av.False(); // Значение установлено в ложь
            av.False(); // Уже ложь
            av.False(); // Уже ложь
            av.True();  // Значение установлено в истину

            WriteLine("SimpleState.Something");
            var sv = new SimpleState.Something.Variable();

            sv.True(); WriteLine(sv);   // True
            sv.False(); WriteLine(sv);  // False
            sv.False();  WriteLine(sv); // False
            sv.False();  WriteLine(sv); // False
            sv.True();  WriteLine(sv);  // True



        }
    }
}
