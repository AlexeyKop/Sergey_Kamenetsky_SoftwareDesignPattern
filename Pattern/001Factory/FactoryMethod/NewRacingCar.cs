using System;
using static System.Console;

namespace FactoryMethod
{
    class NewRacingCar
    {
        string model;
        double engine;
        int maxSpeed;
        int horsepower;

        public static NewRacingCar CrateRacingCar()
        {
            NewRacingCar car = new NewRacingCar()
            {
                maxSpeed = 0,
                horsepower = 0,
                engine = 0.0,
                model = String.Empty
            };
            return car;
        }

        public static NewRacingCar CrateRacingCarAndMaxSpeed(int maxSpeed)
        {
            NewRacingCar car = new NewRacingCar()
            {
                maxSpeed = maxSpeed,
                horsepower = 0,
                engine = 0.0,
                model = String.Empty
            };
            return car;
        }

        public static NewRacingCar CrateRacingCarAndHorsePower(int horsePower)
        {
            NewRacingCar car = new NewRacingCar()
            {
                maxSpeed = 0,
                horsepower = horsePower,
                engine = 0.0,
                model = String.Empty
            };
            return car;
        }


        public void Drive() => WriteLine($"Ты едешь на гоночном болиде");
    }
}
