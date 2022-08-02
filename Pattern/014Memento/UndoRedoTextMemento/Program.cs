using System;
using static System.Console;

namespace TextMemento
{
    class Program
    {
        static void Main()
        {
            TextDocument document = new("0 ");
            document.Change("1 "); WriteLine(document); // 0 1

            document.Undo(); WriteLine(document); // 0
            document.Undo(); WriteLine(document); // 0

            document.Redo(); WriteLine(document); // 0 1

            document.Change("2 ");
            document.Change("3 ");
            document.Change("4 ");
            WriteLine(document);                  // 0 1 2 3 4
            document.Undo(); WriteLine(document); // 0 1 2 3
            document.Redo(); WriteLine(document); // 0 1 2 3 4
            document.Redo(); WriteLine(document); // 0 1 2 3 4
            document.Redo(); WriteLine(document); // 0 1 2 3 4
            document.Redo(); WriteLine(document); // 0 1 2 3 4
            document.Undo(); WriteLine(document); //0 1 2 3
            document.Undo(); WriteLine(document); //0 1 2
            document.Undo(); WriteLine(document); //0 1
            document.Undo(); WriteLine(document); //0
            document.Undo(); WriteLine(document); //0
            document.Undo(); WriteLine(document); //0
            document.Undo(); WriteLine(document); //0
        }
    }
}
