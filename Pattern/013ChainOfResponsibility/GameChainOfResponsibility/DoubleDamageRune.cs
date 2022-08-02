using static System.Console;

namespace GameChainOfResponsibility
{
    public class DoubleDamageRune : Effect
    {
        public DoubleDamageRune(Hero hero)
          : base(hero) { }

        public override void Handle()
        {
            WriteLine($"{hero.Name} активировал руну двойного урона");
            hero.Attack *= 2;
            base.Handle();
        }
    }
}