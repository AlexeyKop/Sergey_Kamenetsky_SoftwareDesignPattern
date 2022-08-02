using static System.Console;
using System.Collections.Generic;
using System.Linq;

namespace SimpleMediator
{
    class ChatMediator : IChat
    {
        private List<User> users;
        public ChatMediator() => users = new List<User>();
        public void AppendUser(User user) => users.Add(user);
        public void SendMessage(string message, User me)
        {
            users.Where(user => user != me)
                 .ToList()
                 .ForEach(e => e.PrintMessage(message));
            WriteLine("====");
        }
    }
}
