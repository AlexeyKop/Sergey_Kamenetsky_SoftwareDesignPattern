namespace GameChainOfResponsibility
{
    public class Effect
    {
        protected Hero hero;
        protected Effect next;

        public Effect(Hero hero) => this.hero = hero;

        public void Add(Effect effect)
        {
            if (next != null) next.Add(effect);
            else next = effect;
        }
        public virtual void Handle() => next?.Handle();
    }
}