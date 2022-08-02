namespace CarDecorator.Cars
{
    public class AudiA6 : Audi
    {
        public AudiA6() : base("A6", new[] { "Кресла", "Двери" })
        { }
        public override int GetPrice()
        {
            return 15000;
        }
    }


}
