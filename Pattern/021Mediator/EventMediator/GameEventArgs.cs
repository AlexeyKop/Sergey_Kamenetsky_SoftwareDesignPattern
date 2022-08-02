using System;

namespace EventMediator
{
    abstract class GameEventArgs: EventArgs
    {
        public abstract void Info();
    }
}
