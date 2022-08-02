using CarBridge.BodyType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBridge.Aktiengesellschaft.Bugatti
{
    public abstract class Bugatti : VolkswagenGroup
    {
        public Bugatti(CarBodyType type) : base(type) { }
    }
}
