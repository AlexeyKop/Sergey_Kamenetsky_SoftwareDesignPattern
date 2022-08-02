using System;
using static System.Console;

namespace SimpleToAbstractFactory
{
    class RacingCar : ICar
    {
        public void Drive() => WriteLine($"Ты едешь на гоночном болиде");
    }
}
