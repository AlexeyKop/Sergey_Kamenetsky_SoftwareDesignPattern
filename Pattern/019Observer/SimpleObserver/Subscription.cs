using System;

namespace SimpleObserver
{
    class Subscription : IDisposable
    {
        private TikTokUser user;
        public IObserver<Event> Observer;
        public Subscription(TikTokUser user, IObserver<Event> observer)
        {
            this.user = user;
            this.Observer = observer;
        }
        public void Dispose() => user.Subscriptions.Remove(this);
    }
}
