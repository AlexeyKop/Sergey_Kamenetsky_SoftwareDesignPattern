using System;
using static System.Console;
using System.Collections.Generic;

namespace SimpleMemento
{
    class Program
    {
        static void Main()
        {

            // Видео https://youtu.be/5eNM5zpAbjM
            List<TextDocument.Memento> mementos = new();

            TextDocument document = new();
            document.SaveTo(mementos);

            document.Change("Строка 1");

            WriteLine(document);  

            document.SaveTo(mementos);
            document.Change("Строка 2");
            document.Change("Строка 3");

            WriteLine(document);  
                                  
                                 
            document.SaveTo(mementos);

            Console.WriteLine("===");

            document.RestoreState(mementos[0]);
            document.SaveTo(mementos); 
            WriteLine(document);              
        }
    }
}
