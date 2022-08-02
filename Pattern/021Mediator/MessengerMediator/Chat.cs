using System.Collections.Generic;
using System.Linq;

namespace MessengerMediator
{
    public class Chat
    {
        private readonly List<User> users = new();
        public void Join(User u)
        {
            string msg = $"{u.Name} присоединился к беседе по ссылке";
            Notify("\nchat", msg);
            u.Chatroom = this;
            users.Add(u);
        }
        public void Notify(string me, string message)
            => users.Where(u => u.Name != me)
                 .ToList()
                 .ForEach(u => u.ReceivingMessage(me, message));
        public void Message(string me, string receiver, string message)
            => users.FirstOrDefault(p => p.Name == receiver)
                ?.ReceivingMessage(me, message);
    }
   
}