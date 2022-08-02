using CarBridge.Arguments;

namespace CarBridge.BodyType
{
    public class SUV : CarBodyType
    {
        public SUV(params Options[] arg) : base(arg) { }
        public override string BodySpecification() { return "SUV"; }
    }
}
