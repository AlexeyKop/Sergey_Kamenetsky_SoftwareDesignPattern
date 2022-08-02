using static System.Console;

namespace IntroEvent1
{

    class Program
    {
        static void Main(string[] args)
        {
            // Видео https://youtu.be/8UUO81WB_5M

            TikTokUser user1 = new() { Nick = "user_1"};
            TikTokUser user2 = new() { Nick = "user_2" };

            user1.VideoPublishing(new MediaFile("Полезная мысль #1"));
            user1.Subscribe(user2);

            user1.VideoPublishing(new MediaFile("Полезная мысль #2"));
            user1.VideoPublishing(new MediaFile("Полезная мысль #3"));

            WriteLine();
            user2.Subscribe(user1);
            user2.VideoPublishing(new MediaFile("Полезная история #1"));
            user2.Unsubscribe(user1);

            ReadLine();
        }
    }
}
