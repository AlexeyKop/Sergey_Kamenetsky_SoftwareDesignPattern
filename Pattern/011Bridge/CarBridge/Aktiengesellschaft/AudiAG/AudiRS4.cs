using CarBridge.BodyType;

namespace CarBridge.Aktiengesellschaft.Audi
{
    public class AudiRS4 : Audi
    {
        public AudiRS4(CarBodyType type) : base(type) { }
        public override string CarInfo() { return $"Audi RS4"; }
    }
}
