using System;
using static System.Console;

namespace AvatarProxy.Characters
{

    public class Human : ActionObject
    {
        public int Age { get; set; }

        public Human()
        {
            this.Age = new Random().Next(14, 70);
        }
        public override void Run()
        {
            WriteLine("Побежали!");
        }

        public Human Clone()
        {
            Human temp = new Human() { Age = this.Age };
            //temp.Property = this.Property;
            // глубокое копирование 
            // если требуется
            return temp;
        }
    }
}
 