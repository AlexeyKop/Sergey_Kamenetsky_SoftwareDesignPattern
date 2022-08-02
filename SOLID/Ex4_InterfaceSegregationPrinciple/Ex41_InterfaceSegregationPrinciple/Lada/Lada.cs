using System;
using System.Collections.Generic;
using System.Text;

namespace RecordPrototype.Lada
{

    public abstract class Lada : Car
    {
        public Lada(string model, string brand)
                : base(model, brand) { }
    }
}