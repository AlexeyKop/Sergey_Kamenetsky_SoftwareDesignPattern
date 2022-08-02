using System;
using static System.Console;

namespace IntroEvent3
{
    class TikTokUser : Account
    {
        private Action<TikTokUser, string> followers;
        public event Action<TikTokUser, string> Followers
        {
            //add => followers += value;
            //remove => followers -= value;

            #region ToDo

            add
            {
                WriteLine($"{(value.Target as Account).Nick} подписался на {this.Nick}");
                followers += value;
            }
            remove
            {
                WriteLine($"{(value.Target as Account).Nick} отказался от подписки на {this.Nick}");
                followers -= value;
            }

            #endregion
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
            if (followers != null) followers(this, fn);
        }
    }
}
