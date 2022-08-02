using System;
using static System.Console;

namespace ObservableProperties
{

    class Program
    {
        static void Main(string[] args)
        {
            Worker w = new Worker();
            w.PropertyChanged += (q, w) => WriteLine($"Изменилось {w.PropertyName}");

            w.Name = "новое имя";
            w.Name = "новое имя";
            w.Name = "новое имя";
            w.Name = "новое имя";

            w.Age = 10;
            w.Age = 0;
            w.Age = 0;
            w.Age = 0;
            w.Age = 0;


        }
    }
}