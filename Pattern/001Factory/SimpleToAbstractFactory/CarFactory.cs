using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleToAbstractFactory
{

    class CarFactory : ICarFactory
    {
        public ICar ProduceCar(TypeCar type)
        {
            switch (type)
            {
                case TypeCar.Truck: 
                    return new RacingCar();

                case TypeCar.Racing: 
                    return new RacingCar();

                default: return new UnknownCar();
            }
        }
    }
}
