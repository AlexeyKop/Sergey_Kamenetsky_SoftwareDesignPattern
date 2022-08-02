using System;

namespace SimpleToAbstractFactory
{
    class Program
    {
        static void Main()
        {
            // Логика...
            var rs4 = CarFactory.ProduceCar(TypeCar.Racing);
            rs4.Drive();

            // Логика...
            var cayenneTurbo = CarFactory.ProduceCar(TypeCar.Racing);
            cayenneTurbo.Drive();


            // Логика...
            var kamazConcreteMixer = CarFactory.ProduceCar(TypeCar.Truck);
            kamazConcreteMixer.Drive();


            // Логика...
            var liebherrConcreteMixer = CarFactory.ProduceCar(TypeCar.Truck);
            liebherrConcreteMixer.Drive();

            // Логика...
            var volvoConcreteMixer = CarFactory.ProduceCar(TypeCar.Truck);
            volvoConcreteMixer.Drive();

        }
    }
}
