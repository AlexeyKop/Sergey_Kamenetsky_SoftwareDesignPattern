namespace SimpleToAbstractFactory
{

    class TuningCarFactory : ICarFactory
    {
        public ICar ProduceCar(TypeCar type)
        {
            switch (type)
            {
                case TypeCar.Truck:
                    return new TuningRacingCar();

                case TypeCar.Racing:
                    return new TuningRacingCar();

                default: return new UnknownCar();
            }
        }
    }
}
