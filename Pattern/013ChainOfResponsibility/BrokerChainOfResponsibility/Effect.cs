using System;
using static System.Console;

namespace BrokerChainOfResponsibility
{
    class Effect : IDisposable
    {
        protected Hero hero;
        protected Game game;

        public Effect(Hero hero, Game game)
        {
            this.hero = hero;
            this.game = game;
            game.Queries += Handlle;
        }

        public virtual void Handlle(object sender, Query e) => WriteLine("Basic Effect");
        public void Dispose() => game.Queries -= Handlle;
    }
}