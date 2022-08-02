
using CarDecorator.Cars;
using System.Collections.Generic;

namespace CarDecorator.Decorator.Configurator
{

    public class AudiAmbientLight : AudiDecorator
    {
        public AudiAmbientLight(Audi audi)
            : base(new List<string>(audi.Options) { "AmbientLight" }, audi)
        { }

        public override int GetPrice()
        {
            return car.GetPrice() + 250;
        }
    }
}
