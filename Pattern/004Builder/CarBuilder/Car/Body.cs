using System;
using System.Collections.Generic;
using System.Text;

namespace CarBuilder.Car
{
    public class Body : Unit
    {



        public override void ToMake()
        {
            Console.WriteLine("Кузов произведён");
        }
    }
}
