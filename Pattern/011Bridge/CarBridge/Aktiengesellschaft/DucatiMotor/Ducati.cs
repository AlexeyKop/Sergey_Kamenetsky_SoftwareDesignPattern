using CarBridge.BodyType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBridge.Aktiengesellschaft.Ducati
{
    public abstract class Ducati : VolkswagenGroup
    {
        public Ducati(CarBodyType type) : base(type) { }
    }
}
