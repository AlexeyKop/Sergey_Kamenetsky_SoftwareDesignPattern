using ScientistStrategy.Skills;
using System;
using static System.Console;

namespace ScientistStrategy
{

    class Program
    {
        static void Main()
        {
            var sined = new Earthling(
            physicsBehavior: new ProfessionalPhysics(),
            programmerBehavior: new ProgrammerPascal(),
            musician: new NoMusician()
            );

            sined.Coding(); // Скрываю, что я это делаю...
            sined.SolveTask(); // Решаю сложные задачи
            sined.Hobby(); // Не играю
            WriteLine();


            sined.ProgrammerBehavior = new ProgrammerNet();
            sined.PhysicsBehavior = new BeginnerPhysics();
            sined.Musician = new Pianist();

            sined.Coding(); // Пишу на C#
            sined.SolveTask(); // Решаю простые задачи
            sined.Hobby(); // Играю на пианино 


        }
    }
}
