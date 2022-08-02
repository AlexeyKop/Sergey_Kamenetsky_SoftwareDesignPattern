using static System.Console;
using System.Collections.Generic;
using PizzaDecorator.Cars.Decorator;
using PizzaDecorator.Cars;

namespace PizzaDecorator
{
    class Program
    {
        static void Main()
        {
            _ = new Car("автомобиль", "опция 1", "опция 2", "опция 3");
            MyCar newCar = new("новый автомобиль", "опция 1", "опция 2", "опция 3");


        }
    }
}
