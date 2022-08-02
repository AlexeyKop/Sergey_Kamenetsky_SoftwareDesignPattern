using static System.Console;
namespace SpeculatorMediator
{
    class Shop : Unit
    {
        public Shop(Mediator mediator) : base(mediator) { }
        public void SellСheese(string component) =>
            WriteLine($"{this.GetType().Name} продано {component}");
    }
}
