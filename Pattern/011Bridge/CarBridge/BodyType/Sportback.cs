using CarBridge.Arguments;
using System;

namespace CarBridge.BodyType
{
    public class Sportback : CarBodyType
    {
        public Sportback(params Options[] arg) : base(arg) { }
        public override string BodySpecification() { return "Sportback"; }
    }
}
