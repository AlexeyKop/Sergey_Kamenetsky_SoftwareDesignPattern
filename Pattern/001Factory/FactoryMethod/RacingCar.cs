using System;
using static System.Console;

namespace FactoryMethod
{
    class RacingCar
    {
        string model;
        double engine;
        int maxSpeed;
        int horsepower;

        public RacingCar(int maxSpeed)
        {
            this.maxSpeed = maxSpeed;
            this.horsepower = 0;
            this.engine = 0.0;
            this.model = String.Empty;
        }

        // Ошибка CS0111  Тип "RacingCar" уже определяет член "RacingCar"
        // с такими же типами параметров.

        //public RacingCar(int horsePower)
        //{
        //    this.maxSpeed = 0;
        //    this.horsepower = horsePower;
        //    this.engine = 0.0;
        //    this.model = String.Empty;
        //}


        public RacingCar()
        {
            this.maxSpeed = 0;
            this.horsepower = 0;
            this.engine = 0.0;
            this.model = String.Empty;
        }

        public RacingCar(string model)
        {
            this.maxSpeed = 0;
            this.horsepower = 0;
            this.engine = 0.0;
            this.model = model;
        }

        public RacingCar(double engine)
        {
            this.maxSpeed = 0;
            this.horsepower = 0;
            this.engine = engine;
            this.model = String.Empty;
        }

        public RacingCar(string model, double engine)
        {
            this.maxSpeed = 0;
            this.horsepower = 0;
            this.engine = engine;
            this.model = model;
        }

        public void Drive() => WriteLine($"Ты едешь на гоночном болиде");
    }
}
