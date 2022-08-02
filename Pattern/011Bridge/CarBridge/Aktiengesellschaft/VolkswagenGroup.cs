using CarBridge.BodyType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBridge.Aktiengesellschaft
{
    public abstract class VolkswagenGroup
    {
        public abstract string CarInfo();

        private readonly CarBodyType bodyType;
        public VolkswagenGroup(CarBodyType type)
        {
            this.bodyType = type;
        }
        
        public override string ToString() => $"{CarInfo()} {bodyType.BodySpecification()}";

    }
}
