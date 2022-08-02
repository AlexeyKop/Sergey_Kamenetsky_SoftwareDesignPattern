using static System.Console;
namespace SpeculatorMediator
{
    class Factory : Unit
    {
        public Factory(Mediator mediator) : base(mediator) { }
        public void MakeMilk(string component)
        {
            string cheese = $"Сыр из {component}";
            WriteLine($"{this.GetType().Name} произвела {cheese}");
            mediator.Do(cheese, this);
        }
    }
}
