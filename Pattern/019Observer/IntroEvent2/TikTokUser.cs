using System;
using static System.Console;

namespace IntroEvent2
{
    class TikTokUser : Account
    {
        public event Action<TikTokUser, string> followers;

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
            followers?.Invoke(this, fn);
        }
    }
}
