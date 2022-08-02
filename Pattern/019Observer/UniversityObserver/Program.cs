using System;
using System.Collections.Generic;
using static System.Console;

namespace UniversityObserver
{
    class Program 
    {
        static void Main(string[] args)
        {
            List<Student> students = new()
            {
                new Student() { Name = "Student1" },
                new Student() { Name = "Student2" },
            };
            var prof = new Professor();

            #region Проверка 1
            
            prof.Add(students);
            prof.TextTo("блабла");
            foreach (var student in students) student.ShowNotebook("Проверка 1");
            WriteLine("\n=========\n");
            ReadKey();
            #endregion

            #region Проверка 2

            prof.TextTo("бла");
            foreach (var student in students) student.ShowNotebook("Проверка 2");
            WriteLine("\n=========\n");
            ReadKey();
            #endregion

            #region Проверка 3

            prof.Remove(students[1]);
            prof.TextTo("БЛА!");
            foreach (var student in students) student.ShowNotebook("Проверка 3");
            WriteLine("\n=========\n");
            ReadKey();
            #endregion

            #region Проверка 4

            prof.Add(students[1]);
            prof.TextTo("Всем спасибо!");
            foreach (var student in students) student.ShowNotebook("Проверка 4");
            WriteLine("\n=========\n");

            #region 

            Title = String.Empty;
            ReadLine();

            #endregion

             #endregion
        }
    }
}