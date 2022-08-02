using System;
using System.Collections.Generic;
using static System.Console;

namespace TextMemento
{
    class Program
    {
        static void Main()
        {
            #region v1

            List<Memento> mementos = new();

            //TextDocument document = new TextDocument();
            //mementos.Add(document.Change("Строка 1"));
            //mementos.Add(document.Change("Строка 2"));
            //mementos.Add(document.Change("Строка 3"));

            //WriteLine(document);
            ////Строка 1
            ////Строка 2
            ////Строка 3

            //document.RestoreState(mementos[1]);
            //WriteLine(document);
            ////Строка 1
            ////Строка 2

            #endregion

            #region v2

            TextDocument document = new();
            document.Change("Строка 1").SaveState(mementos);
            document.Change("Строка 2").SaveState(mementos);
            document.Change("Строка 3").SaveState(mementos);
             

            WriteLine(document);
            //Строка 1
            //Строка 2
            //Строка 3

            document.RestoreState(mementos[1]);
            WriteLine(document);
            //Строка 1
            //Строка 2

            #endregion
        }
    }
}
