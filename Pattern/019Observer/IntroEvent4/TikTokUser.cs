using System;
using static System.Console;

namespace IntroEvent4
{
    class TikTokUser : Account
    {
        private EventHandler<MediaFileEventArgs> followers;

        public event EventHandler<MediaFileEventArgs> Followers
        {
            add => followers += value;
            remove => followers -= value;
        }
        public void Alert(object sender, MediaFileEventArgs e)
        {
            if (sender != this) 
                WriteLine($"Лента {this.Nick}: У {(sender as Account).Nick} вышло {e.FileName}");
            else WriteLine($"У меня({this.Nick}) вышло {e.FileName}");
        }

        public void VideoPublishing(MediaFile media)
        {
            Alert(this, media);
            //if (followers != null) followers(this, media);
            followers?.Invoke(this, media);
        }
    }
}
