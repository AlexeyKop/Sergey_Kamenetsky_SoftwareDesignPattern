namespace SimpleToAbstractFactory
{
    class Factory
    {
        public static ICarFactory GetFactory(bool tuning) =>
            tuning ? new TuningCarFactory() : new CarFactory();
    }
}
