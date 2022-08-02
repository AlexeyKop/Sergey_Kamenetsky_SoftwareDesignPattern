using System;
using static DFA.State;
using static System.Console;
namespace DFA
{
    /// <summary>
    /// возможные состояния
    /// </summary>
    enum State
    {
        Start,
        FirstNumber,
        SecondNumber,
        Operation,
        LeftBracket,
        RightBracket,
        Complete,
        Mistake
    };

    class Program
    {
        static bool Run()
        {
            State currentState = Start;
            string nums = "0123456789";
            string ops = "+-*/";
            do
            {
                var state = ReadKey().KeyChar;
                switch (currentState)
                {
                    case Start:
                        if (state == '(') currentState = LeftBracket;
                        else currentState = Mistake;
                        break;

                    case LeftBracket:
                        if (nums.IndexOf(state) != -1) currentState = FirstNumber;
                        else currentState = Mistake;
                        break;

                    case FirstNumber:
                        if (nums.IndexOf(state) != -1) currentState = FirstNumber;
                        else if (ops.IndexOf(state) != -1) currentState = Operation;
                        else currentState = Mistake;
                        break;

                    case Operation:
                        if (nums.IndexOf(state) != -1) currentState = SecondNumber;
                        else currentState = Mistake;
                        break;

                    case SecondNumber:
                        if (nums.IndexOf(state) != -1) currentState = SecondNumber;
                        else if (state == ')')
                        {
                            currentState = RightBracket;
                            goto case RightBracket;
                        }
                        else currentState = Mistake;
                        break;

                    case RightBracket:
                        currentState = Complete;
                        break;

                    case Complete:
                        break;
                    case Mistake:
                        break;
                }
            }
            while (currentState != Complete && currentState != Mistake);
            return currentState == Complete;
        }

        static void Main()
        {
            for (int i = 0; true; i++)
            {
                Write($"Попытка {i} >> ");
                WriteLine($": {Run()}");
            }
        }
    }
}