using System;
using static System.Console;

namespace IntroEvent2
{


    class MediaFile
    {
        public MediaFile(string fileName) => FileName = fileName;
        public string FileName { get; set; }
    }
    class Video : MediaFile
    {
        public Video(string fileName) : base(fileName) { }
    }
    class TikTokUser
    {
        public string Nick { get; set; }
        public Action<TikTokUser, string> followers;

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

    class Program
    {
        static void Main(string[] args)
        {
            TikTokUser user1 = new() { Nick = "user_1" };
            TikTokUser user2 = new() { Nick = "user_2" };

            user1.VideoPublishing(new MediaFile("Полезная мысль #1"));
            user1.followers += user2.Alert;

            user1.VideoPublishing(new MediaFile("Полезная мысль #2"));
            user1.VideoPublishing(new MediaFile("Полезная мысль #3"));

            WriteLine();
            user2.followers += user2.Alert;
            user2.VideoPublishing(new MediaFile("Полезная история #1"));

            ReadLine();
        }
    }
}
