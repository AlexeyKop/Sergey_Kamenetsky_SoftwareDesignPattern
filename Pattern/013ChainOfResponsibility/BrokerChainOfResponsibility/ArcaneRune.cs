namespace BrokerChainOfResponsibility
{
    class ArcaneRune : Effect
    {
        public ArcaneRune(Hero hero, Game game) : base(hero, game) { }
        public override void Handlle(object sender, Query e) => base.Handlle(sender, e);
        /// Тут должна была быть логика,
        /// но 3:40 на часах меня остановило
        /// Когда-нибудь доделаю, но это не точно
        /// Или предлагаю самостоятельно 😉
    }
}