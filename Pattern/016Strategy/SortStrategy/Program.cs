using System.Collections.Generic;
using static System.Console;

namespace SortStrategy
{
    class Program
    {
        static void Main()
        {
            List<Worker> db = new()
            {
                new() { Name = "Worker 1", Age = 55, Salary = 1 },
                new() { Name = "Worker 2", Age = 33, Salary = 2 },
                new() { Name = "Worker 3", Age = 66, Salary = 6 },
                new() { Name = "Worker 4", Age = 22, Salary = 24 },
                new() { Name = "Worker 5", Age = 44, Salary = 120 }
            };

            //Worker 1 55 1
            //Worker 2 33 2
            //Worker 3 66 6
            //Worker 4 22 24
            //Worker 5 44 120
            foreach (var item in db) WriteLine(item);
            // db.Sort(); // InvalidOperationException
            WriteLine();
            db.Sort((a, b) => a.Age < b.Age ? -1 : 1);

            //Worker 4 22 24
            //Worker 2 33 2
            //Worker 5 44 120
            //Worker 1 55 1
            //Worker 3 66 6
            foreach (var item in db) WriteLine(item);


            db.Sort((a, b) => a.Salary > b.Salary ? -1 : 1);
            WriteLine();

            //Worker 5 44 120
            //Worker 4 22 24
            //Worker 3 66 6
            //Worker 2 33 2
            //Worker 1 55 1
            foreach (var item in db) WriteLine(item);


        }
    }
}
