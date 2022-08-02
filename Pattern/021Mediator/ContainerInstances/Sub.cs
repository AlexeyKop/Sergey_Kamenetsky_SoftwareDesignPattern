namespace ContainerInstances
{
    class Sub : ICalc
    {
        public string Operation { get; init; } = "-";
        public double Result(double x, double y) => x - y;
    }
}
