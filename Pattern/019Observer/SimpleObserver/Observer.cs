using System;
using static System.Console;

namespace SimpleObserver
{
    class Observer : IObserver<Event>
    {
        public Observer()
        {
            var user = new TikTokUser();
            var sub = user.Subscribe(this);
            user.Alert();
            user.Alert();
            sub.Dispose();
            user.Alert();
        }
        public void OnNext(Event value)
        {
            // Происходит в момент получения данных
            if (value is LoggerEvent) WriteLine("Произошло событие OnNext value is LoggerEvent ");
            if (value is AlertEvent) WriteLine("Произошло событие OnNext value is AlertEvent ");
        }

        public void OnCompleted()
        {
            // Если наблюдение окончено больше ничего 
            // происходить не будет
        }
        public void OnError(Exception error)
        {
            // Происходит, если произошла ошибка,
            // которую нужно обрабатывать
            // и об этом есть явное оповещение об этом
        }
    }
}
