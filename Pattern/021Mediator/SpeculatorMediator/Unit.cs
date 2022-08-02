namespace SpeculatorMediator
{
    public abstract class Unit
    {
        protected Mediator mediator;
        public Unit(Mediator mediator) => this.mediator = mediator;
    }
}
