using System;

namespace MessengerMediator
{
    public class Program
    {
        static void Main()
        {
            var chat = new Chat();
            var r2d2 = new User("r2d2");
            var c3pO = new User("c3pO");
            chat.Join(r2d2); 
            chat.Join(c3pO); 
            r2d2.SendPublicMessage("Я r2d2");
            c3pO.SendPublicMessage("Привет! Я c3pO");
            var bb8 = new User("bb8");
            chat.Join(bb8);
            
            bb8.SendPublicMessage("Здрасти! Я bb8");
            c3pO.SendPrivateMessage("bb8", "(-;");
        }
    }
}