
using System;
using System.Collections.Generic;

namespace CarDecorator.Cars
{
    public abstract class Audi
    {
        public string Model { get; set; }
        public Audi(string model, IEnumerable<string> options)
        {
            Model = model;
            this.Options = new List<string>(options);
        }
        public List<string> Options { get; protected set; }
        public abstract int GetPrice();
        public override string ToString()
        {
            return String.Format(
                   "Model: Audi {0} Options: {1} Price: {2}"
                   , Model
                   , String.Join(" ", this.Options)
                   , GetPrice()
                   );
        }
    }
}
