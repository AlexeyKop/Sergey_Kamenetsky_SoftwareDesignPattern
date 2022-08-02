using static System.Console;

namespace GameChainOfResponsibility
{
    public class ArcaneRune : Effect
    {
        public ArcaneRune(Hero hero)
          : base(hero) { }

        public override void Handle()
        {
            WriteLine($"{hero.Name} активировал руну волшебства");
            /// Тут должна была быть логика,
            /// но 3:40 на часах меня остановило
            /// Когда-нибудь доделаю, но это не точно
            /// Или предлагаю самостоятельно 😉
            base.Handle();
        }
    }
}