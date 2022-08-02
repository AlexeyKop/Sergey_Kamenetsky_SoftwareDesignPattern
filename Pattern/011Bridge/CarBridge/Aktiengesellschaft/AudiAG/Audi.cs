using CarBridge.BodyType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBridge.Aktiengesellschaft.Audi
{
    public abstract class Audi : VolkswagenGroup
    {
        public Audi(CarBodyType type) : base(type) { }
    }
}
