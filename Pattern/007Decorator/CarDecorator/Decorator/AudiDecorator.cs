
using CarDecorator.Cars;
using System.Collections.Generic;

namespace CarDecorator.Decorator
{
    public abstract class AudiDecorator : Audi
    {
        protected Audi car;
        public AudiDecorator(IEnumerable<string> options, Audi myAudi) 
            : base(myAudi.Model,options)
        {
            this.car = myAudi;
        }
    }
}
