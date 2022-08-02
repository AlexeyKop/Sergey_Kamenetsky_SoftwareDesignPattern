namespace SpeculatorMediator
{
    class Program
    {
        static void Main()
        {
            var dak = new Speculator();

            var farmer = new Farmer(mediator: dak);
            var factory = new Factory(mediator: dak);
            var shop = new Shop(mediator: dak);

            dak.ConcreteFarmer = farmer;
            dak.ConcreteFactory = factory;
            dak.ConcreteShop = shop;

            farmer.GetMilk();
        }
    }
}
