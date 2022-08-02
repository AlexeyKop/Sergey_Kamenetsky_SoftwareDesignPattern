using System;
using static System.Console;

namespace TerminalExample
{

    class Program
    {
        static void Main()
        {
            while (true)
            {

                Write("\nInput: ");
                Context context = new Context
                {
                    Alphabet = new string[] { "class", "for", "in" },
                    Chain = ReadLine()
                };

                NoTerminal.Interpret(context);

                WriteLine(context.Result);
                WriteLine(context.Position);
            }
        }
    }
}