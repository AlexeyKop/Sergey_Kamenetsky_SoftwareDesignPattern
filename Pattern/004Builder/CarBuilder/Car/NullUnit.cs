using System;

namespace CarBuilder.Car
{
    class NullUnit : Unit
    {
        public override void ToMake()
        {
            Console.WriteLine("Пока что не научился");
        }
    }
}
