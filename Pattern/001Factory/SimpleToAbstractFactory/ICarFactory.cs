namespace SimpleToAbstractFactory
{
    interface ICarFactory
    {
        ICar ProduceCar(TypeCar type);
    }
}
