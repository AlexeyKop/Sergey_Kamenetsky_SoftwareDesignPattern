using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleToAbstractFactory
{
    class CarFactory
    {
        public static ICar ProduceCar(TypeCar type)
        {
            switch (type)
            {
                case TypeCar.Truck: 
                    return new RacingCar();
                    //return new RacingCar(engine: ...);
                    //return new RacingCar(model: ..., engine: ...);



                case TypeCar.Racing: 
                    return new ConcreteMixerCar();
                    //return new ConcreteMixerCar()(engine: ...);
                    //return new ConcreteMixerCar()(model: ..., engine: ...);



                default: return new UnknownCar();
            }
        }
    }
}
