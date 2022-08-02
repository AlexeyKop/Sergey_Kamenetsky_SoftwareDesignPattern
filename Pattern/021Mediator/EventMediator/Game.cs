using System;

namespace EventMediator
{
    class Game
    {
        public event EventHandler<GameEventArgs> AbstractEvent;
        public void Alert(GameEventArgs args) => AbstractEvent?.Invoke(this, args);
    }
}
