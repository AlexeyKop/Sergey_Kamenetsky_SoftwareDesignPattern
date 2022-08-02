using System;

namespace ClassicChainOfResponsibility
{
    class Hero : IHero
    {
        public int Hp { get; set; }
        public Hero Next { get; set; }

        public string Name => this.GetType().Name;

        public Hero(int hp, Hero hero)
        {
            this.Hp = hp;
            Next = hero;
        }

        public void MustWin(Roshan enemy)
        {
            if (this.Hp > enemy.Hp)
            {
                Console.WriteLine($"{Name} смог");
            }
            else
            {
                if (Next != null)
                {
                    Console.WriteLine($"{Name} не смог. Попробует {(Next.GetType().Name)}");
                    Next.MustWin(enemy);
                    return;
                }
                Console.WriteLine($"{Name} Не смог. Враг победил");
            }
        }
    }
}
