using CarBridge.Arguments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBridge.BodyType
{
    class Sedan : CarBodyType
    {
        public Sedan(params Options[] arg) : base(arg) { }

        public override string BodySpecification() { return "Sedan"; }
    }
}
