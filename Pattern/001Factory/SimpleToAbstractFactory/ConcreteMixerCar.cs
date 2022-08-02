using System;
using static System.Console;

namespace SimpleToAbstractFactory
{

    class ConcreteMixerCar : ICar
    {
        public void Drive() => WriteLine($"Ты едешь на бетономешалке");
    }
}
