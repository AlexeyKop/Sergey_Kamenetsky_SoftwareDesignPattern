using System;
using static System.Console;

namespace IntroEvent1
{
    class TikTokUser : Account
    {
        protected Action<TikTokUser, string> followers;
        public void Subscribe(TikTokUser user)
        {
            WriteLine($"{user.Nick} подписался на {this.Nick}");
            followers += user.Alert;
        }
        public void Unsubscribe(TikTokUser user)
        {
            WriteLine($"{user.Nick} отказался от подписки на {this.Nick}");
            followers -= user.Alert;
        }
        public void Alert(TikTokUser sender, string info)
        {
            if (sender != this) WriteLine($"Лента {this.Nick}: У {sender.Nick} {info}");
            else WriteLine($"У меня({this.Nick}) {info}");
        }
        public void VideoPublishing(MediaFile media)
        {
            //var fn = media.FileName;
            var fn = $"вышло видео '{media.FileName}'";
            Alert(this, fn);
            //if (followers != null) followers(this, fn);
            followers?.Invoke(this, fn);

        }
    }
}
