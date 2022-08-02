using System;
using static System.Console;

namespace WithoutFactory
{
    //class ConcreteMixerCar
    //{
    //    public void Drive() => WriteLine($"Ты едешь на бетономешалке");
    //}


    //class ConcreteMixerCar
    //{
    //    readonly double engine;

    //    public ConcreteMixerCar(double engine)
    //    {
    //        this.engine = engine;
    //    }

    //    public void Drive() => WriteLine($"Ты едешь на бетономешалке");
    //}

    class ConcreteMixerCar
    {
        readonly string model;
        readonly double engine;

        public ConcreteMixerCar(string model, double engine)
        {
            this.engine = engine;
            this.model = model;
        }

        public void Drive() => WriteLine($"Ты едешь на бетономешалке");
    }
}
