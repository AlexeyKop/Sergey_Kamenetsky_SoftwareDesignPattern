using static System.Console;

namespace GameChainOfResponsibility
{
    public class Halberd : Effect
    {
        public Halberd(Hero hero)
          : base(hero) { }

        public override void Handle()
        {
            WriteLine("Существо лишено сил, отчего оно не может атаковать.");
            hero.Attack = 0;
        }
    }
}