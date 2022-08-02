using System;
using static System.Console;

namespace CompanyFlyweightSimple
{



    class Program
    {
        static void Main()
        {
            //var s = new Employee("#имя: иван #фамилия c #должность учитель");
            //var q = new Employee("#имя: саша #фамилия б #должность программист");
            //var u = new Employee("#имя: денис #фамилия к #должность учитель");
            //var a = new Employee("#имя: андрей #фамилия р #должность программист");
            //var d = new Employee("#имя: серёня #фамилия к #должность учитель");

            var db = new Repository();

            var s = new Employee("иван c учитель", db);
            var q = new Employee("саша б программист", db);
            var u = new Employee("денис к учитель", db);
            var a = new Employee("андрей р программист", db);
            var d = new Employee("серёня к учитель", db);

            WriteLine();


            WriteLine(s);
            WriteLine(q);
            WriteLine(u);
            WriteLine(a);
            WriteLine(d);

            WriteLine();


            WriteLine(String.Join("\n", Repository.data));
        }
    }
}