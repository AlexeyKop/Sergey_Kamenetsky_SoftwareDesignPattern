using CarBridge.BodyType;

namespace CarBridge.Aktiengesellschaft.Audi
{
    public class Etron : Audi
    {
        public Etron(CarBodyType type) : base(type) { }
        public override string CarInfo() { return $"Audi e-tron"; }
    }
}
