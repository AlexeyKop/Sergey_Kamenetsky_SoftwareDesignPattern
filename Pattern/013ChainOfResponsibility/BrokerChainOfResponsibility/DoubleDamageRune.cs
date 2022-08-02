namespace BrokerChainOfResponsibility
{
    class DoubleDamageRune : Effect
    {
        public DoubleDamageRune(Hero hero, Game game) : base(hero, game) { }

        public override void Handlle(object sender, Query e)
        {
            if (e.HeroName == hero.Name
                && e.TypeEffect == (GameEffect.DoubleDamageRune | GameEffect.HalberdEffect))
            { e.Args = new Characteristic { Armor = e.Args.Armor, Attack = 2 * e.Args.Attack }; }
        }
    }
}