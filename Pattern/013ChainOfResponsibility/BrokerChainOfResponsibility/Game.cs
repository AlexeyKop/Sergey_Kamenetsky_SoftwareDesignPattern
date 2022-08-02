using System;

namespace BrokerChainOfResponsibility
{
    class Game
    {
        public event EventHandler<Query> Queries;
        public void CallQuery(object s, Query q) => Queries?.Invoke(s, q);
    }
}