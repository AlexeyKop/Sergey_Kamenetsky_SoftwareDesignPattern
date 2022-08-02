using System;
using System.Collections.Generic;
using System.Text;

namespace RecordPrototype
{
    public abstract class Car
    {
        public string Model { get; set; }
        public string Brand { get; set; }

        public Car(string model, string brand)
        {
            this.Model = model;
            this.Brand = brand;
        }
    }
}
