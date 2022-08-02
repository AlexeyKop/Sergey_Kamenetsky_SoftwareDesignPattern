using CarDecorator.Cars;
using System.Collections.Generic;

namespace CarDecorator.Decorator.Configurator
{
    public class AudiColorVesuviusGrayMetallic: AudiDecorator
    {
        public AudiColorVesuviusGrayMetallic(Audi audi)
            : base(new List<string>(audi.Options) { ExteriorColors.VesuviusGrayMetallic.ToString() }
                    , audi)
        { }

        public override int GetPrice()
        {
            return car.GetPrice() + 1200;
        }
    }
}
