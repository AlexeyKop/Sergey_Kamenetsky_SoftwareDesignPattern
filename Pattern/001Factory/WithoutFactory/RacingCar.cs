using System;
using static System.Console;

namespace WithoutFactory
{

    //class RacingCar
    //{
    //    public void Drive() => WriteLine($"Ты едешь на гоночном болиде");
    //}

    //class RacingCar
    //{
    //    readonly double engine;

    //    public RacingCar(double engine)
    //    {
    //        this.engine = engine;
    //    }

    //    public void Drive() => WriteLine($"Ты едешь на гоночном болиде");
    //}

    class RacingCar
    {
        readonly string model;
        readonly double engine;

        public RacingCar(string model, double engine)
        {
            this.engine = engine;
            this.model = model;
        }

        public void Drive() => WriteLine($"Ты едешь на гоночном болиде");
    }
}
