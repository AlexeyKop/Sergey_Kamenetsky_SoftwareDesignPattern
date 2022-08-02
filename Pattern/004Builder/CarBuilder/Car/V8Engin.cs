using System;

namespace CarBuilder.Car
{
    class V8Engin : Engine
    {
        public override void ToMake()
        {
            Console.WriteLine("Двигатель для гоночного болида произведён");
        }
    }

}
