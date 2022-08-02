using CarBridge.BodyType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBridge.Aktiengesellschaft.BentleyMotors
{
    public abstract class Bentley : VolkswagenGroup
    {
        public Bentley(CarBodyType type) : base(type) { }
    }
}
