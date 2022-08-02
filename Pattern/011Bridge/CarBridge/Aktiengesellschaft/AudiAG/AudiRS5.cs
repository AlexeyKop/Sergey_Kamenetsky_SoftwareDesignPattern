using CarBridge.BodyType;

namespace CarBridge.Aktiengesellschaft.Audi
{
    public class AudiRS5 : Audi
    {
        public AudiRS5(CarBodyType type) : base(type) { }
        public override string CarInfo() { return $"Audi RS5"; }
    }
}
