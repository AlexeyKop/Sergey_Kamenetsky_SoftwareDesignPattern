using CarBridge.BodyType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBridge.Aktiengesellschaft.PorscheAG
{
    public abstract class Porsche : VolkswagenGroup
    {
        public Porsche(CarBodyType type) : base(type) { }
    }
}
