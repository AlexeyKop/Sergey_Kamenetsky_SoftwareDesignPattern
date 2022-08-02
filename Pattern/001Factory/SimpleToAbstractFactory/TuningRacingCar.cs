using static System.Console;

namespace SimpleToAbstractFactory
{
    class TuningRacingCar : ICar
    {
        public void Drive() => WriteLine($"Ты едешь на прокаченном гоночном болиде");
    }
}
