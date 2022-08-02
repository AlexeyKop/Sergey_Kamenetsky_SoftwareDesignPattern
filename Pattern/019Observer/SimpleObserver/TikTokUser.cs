using System;
using System.Collections.Generic;

namespace SimpleObserver
{
    /// <summary>
    /// Класс, за которым можно наблюдать
    /// получая оповещения о происходящих в нём событиях
    /// </summary>
    class TikTokUser : IObservable<Event>
    {
        public List<Subscription> Subscriptions { get; init; }

        public TikTokUser() => Subscriptions = new List<Subscription>();

        public void Alert()
        {
            Random r = new Random();
            foreach (var sub in Subscriptions)
            {
                Event e = r.Next(2) switch
                {
                    0 => new LoggerEvent(),
                    _ => new AlertEvent()
                };
                sub.Observer.OnNext(e);
            }
        }

        //                           IObserver - тот, кто хочет получать 
        //                           уведомления от наблюдаемого класса
        public IDisposable Subscribe(IObserver<Event> observer)
        {
            // IDisposable - как правило реализуют с целью возможной отписки
            var sub = new Subscription(this, observer);
            Subscriptions.Add(sub);
            return sub;
        }
    }
}
