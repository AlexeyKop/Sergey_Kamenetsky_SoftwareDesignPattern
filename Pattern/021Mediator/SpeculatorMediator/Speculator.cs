namespace SpeculatorMediator
{
    class Speculator : Mediator
    {
        public Farmer ConcreteFarmer { get; set; }
        public Factory ConcreteFactory { get; set; }
        public Shop ConcreteShop { get; set; }
        public override void Do(string component, Unit unit)
        {
            if (unit == ConcreteFarmer) { ConcreteFactory.MakeMilk(component); }
            else if (unit == ConcreteFactory) { ConcreteShop.SellСheese(component); }
        }
    }
}
