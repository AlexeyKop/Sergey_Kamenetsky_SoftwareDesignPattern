using CarBuilder.Car;

namespace CarBuilder.Builder
{
    class BolideBuilder : AbstractBuilder
    {
        public BolideBuilder() { bolide = new Bolide(); }

        Bolide bolide;

        public override Vehicle GetResult { get { return bolide; } }

        public override void MakeBody() { bolide.AddPart(new Body()); }

        public override void MakeEngine() { bolide.AddPart(new V8Engin()); }

        public override void MakeSuspension() { bolide.AddPart(new Suspension()); }
    }
}
