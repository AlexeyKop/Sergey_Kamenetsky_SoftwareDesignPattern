using System.Collections.Generic;
using static System.Console;

namespace MessengerMediator
{
    public class User
    {
        public string Name { get; set; }
        public Chat Chatroom { get; set; }
        private readonly List<string> chatLog = new();
        public User(string name) => Name = name;
        public void ReceivingMessage(string sender, string message)
        {
            string s = $"{sender}: {message}";
            WriteLine($"Messenger {Name}: {s}");
            chatLog.Add(s);
        }
        public void SendPublicMessage(string message) 
            => Chatroom.Notify(Name, message);

        public void SendPrivateMessage(string who, string message)
            => Chatroom.Message(Name, who, message);
    }
   
}