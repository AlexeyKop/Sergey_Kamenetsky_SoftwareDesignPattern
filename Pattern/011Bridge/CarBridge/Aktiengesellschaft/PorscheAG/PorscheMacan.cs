using CarBridge.BodyType;

namespace CarBridge.Aktiengesellschaft.PorscheAG
{
    public class PorscheMacan : Porsche
    {
        public PorscheMacan(CarBodyType type) : base(type) { }
        public override string CarInfo() { return $"Porsche Macan"; }
    }
}
