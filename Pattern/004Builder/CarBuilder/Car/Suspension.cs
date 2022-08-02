using System;
using System.Collections.Generic;
using System.Text;

namespace CarBuilder.Car
{
    public class Suspension : Unit
    {
        public override void ToMake()
        {
            Console.WriteLine("Подвеска произведена");
        }
    }
}
