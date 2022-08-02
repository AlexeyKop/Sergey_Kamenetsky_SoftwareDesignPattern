
using CarDecorator.Cars;
using CarDecorator.Decorator;
using System.Collections.Generic;

namespace CarDecorator.Decorator.Configurator
{
    public class AudiMatrixLed : AudiDecorator
    {
        public AudiMatrixLed(Audi audi)
            : base(new List<string>(audi.Options) { "AudiMatrixLed" }, audi)
        { }

        public override int GetPrice()
        {
            return car.GetPrice() + 550;
        }
    }
}
