namespace ContainerInstances
{
    interface ICalc
    {
        string Operation { get; init; }
        double Result(double x, double y);
    }
}
