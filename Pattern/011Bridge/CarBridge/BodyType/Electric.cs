using CarBridge.Arguments;

namespace CarBridge.BodyType
{
    public class Electric : CarBodyType
    {
        public Electric(params Options[] arg) : base(arg) { }
        public override string BodySpecification() { return "Electric"; }
    }
}
