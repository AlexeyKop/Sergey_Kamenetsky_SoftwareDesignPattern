using CarBuilder.Car;
using System.Collections.Generic;
using System.Text;

namespace CarBuilder.Builder
{

    class MotorbikeBuilder : AbstractBuilder
    {
        public MotorbikeBuilder() { motorbike = new Motorbike(); }

        Motorbike motorbike;

        public override Vehicle GetResult { get { return motorbike; } }

        public override void MakeBody() { motorbike.AddPart(new Body()); }

        public override void MakeEngine() { motorbike.AddPart(new MotorbikeEngin()); }

        public override void MakeSuspension() { motorbike.AddPart(new Suspension()); }
    }
}
