using AbstractFactory.Abstractions;
using AbstractFactory.Infrastructure;

namespace AbstractFactory
{
    class Customer
    {

        private AbstractCar car;

        public Customer(Abstractions.AbstractFactory factory, Models model)
        {
            factory.Model = model;
            car = factory.GetCar();
        }
        
        public void Buy()
        {
            car.Run();
        }
    }
}
