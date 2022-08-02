namespace ContainerInstances
{
    class Mult : ICalc
    {
        public string Operation { get; init; } = "*";
        public double Result(double x, double y) => x * y;
    }
}
