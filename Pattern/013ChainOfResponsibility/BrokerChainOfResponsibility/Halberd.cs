namespace BrokerChainOfResponsibility
{
    class Halberd : Effect
    {
        public Halberd(Hero hero, Game game) : base(hero, game) { }
        public override void Handlle(object sender, Query e)
        {
            if (e.HeroName == hero.Name
                && e.TypeEffect == GameEffect.HalberdEffect)
            { { e.Args = new Characteristic { Armor = 1000, Attack = 0 }; } }
        }
    }
}