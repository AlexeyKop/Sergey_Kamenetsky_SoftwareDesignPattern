using static System.Console;

namespace IntroEvent3
{

    class Program
    {
        static void Main(string[] args)
        {
            TikTokUser user1 = new() { Nick = "user_1" };
            TikTokUser user2 = new() { Nick = "user_2" };
            TikTokUser user3 = new() { Nick = "user_3" };
            TikTokUser user4 = new() { Nick = "user_4" };
            TikTokUser user5 = new() { Nick = "user_5" };

            user1.VideoPublishing(new MediaFile("Полезная мысль #1"));
            user1.Followers += user2.Alert;
            user1.Followers += user3.Alert;
            user1.Followers += user4.Alert;
            user1.Followers += user5.Alert;

            user1.VideoPublishing(new MediaFile("Полезная мысль #2"));
            user1.VideoPublishing(new MediaFile("Полезная мысль #3"));

            WriteLine();
            user2.Followers += user2.Alert;
            user2.VideoPublishing(new MediaFile("Полезная история #1"));

            ReadLine();
        }
    }
}
