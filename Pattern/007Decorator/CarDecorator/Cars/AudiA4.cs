namespace CarDecorator.Cars
{
    public class AudiA4 : Audi
    {
        public AudiA4() : base("A4", new[] { "Кресла", "Двери" })
        { }
        public override int GetPrice()
        {
            return 10000;
        }
    }


}
