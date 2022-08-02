using static System.Console;
namespace SpeculatorMediator
{
    public class Farmer : Unit
    {
        public Farmer(Mediator mediator) : base(mediator) { }

        public void GetMilk()
        {
            string milk = "Молоко";
            WriteLine($"{this.GetType().Name} предоставляет {milk}");
            mediator.Do(milk, this);
        }
    }
}
