using System;
using System.Text;
using static System.Console;

namespace UniversityObserver
{
    class Student : IPropertyObserver
    {
        public string Name { get; set; }
        StringBuilder notebook;

        public Student() => notebook = new StringBuilder();

        public void SpeechTo(string text) => notebook.Append($"{text}\n");
        
        public void ShowNotebook(string note = "")
        {
            if (note != String.Empty)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine(note);
                ForegroundColor = ConsoleColor.White;
            }
            WriteLine($"Тетрадь {Name}\n{notebook.ToString()}");
        }
    }
}