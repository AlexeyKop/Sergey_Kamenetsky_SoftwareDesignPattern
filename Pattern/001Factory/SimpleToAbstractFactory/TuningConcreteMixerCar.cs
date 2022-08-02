using static System.Console;

namespace SimpleToAbstractFactory
{
    class TuningConcreteMixerCar : ICar
    {
        public void Drive() => WriteLine($"Ты едешь на прокаченной бетономешалке");
    }
}
