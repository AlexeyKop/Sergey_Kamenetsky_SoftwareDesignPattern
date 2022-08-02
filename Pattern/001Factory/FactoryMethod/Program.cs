using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new RacingCar();
            var car2 = new RacingCar(engine: 2.8);
            var car3 = new RacingCar(model: "Porsche 990");
            var car4 = new RacingCar(model: "Porsche 990", engine: 2.8);


            //var car = new NewRacingCar(...);
            var car5 = NewRacingCar.CrateRacingCar();
            var car6 = NewRacingCar.CrateRacingCarAndMaxSpeed(228);
            var car7 = NewRacingCar.CrateRacingCarAndHorsePower(249);

        }
    }
}
