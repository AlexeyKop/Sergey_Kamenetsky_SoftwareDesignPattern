using System;

namespace SimpleToAbstractFactory
{

    class Program
    {
        static void Main(string[] args)
        {
            ICarFactory myFactory = Factory.GetFactory(tuning: true);
          
            ICar car = myFactory.ProduceCar(TypeCar.Racing);
            car.Drive(); // Ты едешь на прокаченном гоночном болиде

            car = myFactory.ProduceCar(TypeCar.Racing);
            car.Drive(); // Ты едешь на прокаченном гоночном болиде


            myFactory = Factory.GetFactory(tuning: !true);
            car = myFactory.ProduceCar(TypeCar.Racing);
            car.Drive(); // Ты едешь на гоночном болиде

            car = myFactory.ProduceCar(TypeCar.Racing);
            car.Drive(); // Ты едешь на гоночном болиде

        }
    }
}
