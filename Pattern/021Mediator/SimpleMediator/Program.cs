namespace SimpleMediator
{
    class Program
    {
        static void Main()
        {
            // Видео https://youtu.be/1fyZokexZKI
            ChatMediator chat = new ChatMediator();
            
            var r2d2 = new User(chat, "r2d2");
            var c3pO = new User(chat, "c3pO");
            var bb8 = new User(chat, "bb8");

            chat.AppendUser(r2d2);
            r2d2.SendMessage("I'm r2d2");

            chat.AppendUser(c3pO);
            c3pO.SendMessage("hi! I'm c3pO");

            chat.AppendUser(bb8);
            bb8.SendMessage("hello! I'm bb8");

            r2d2.SendMessage("hi everyone! I'm r2d2");
        }
    }
}
