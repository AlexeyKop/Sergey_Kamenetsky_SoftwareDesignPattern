using static System.Console;

namespace SimpleMediator
{
    class User
    {
        private IChat chatroom;
        private string nickname;
        public string Nickname => nickname;
        public User(IChat chat, string nick)
        {
            this.chatroom = chat;
            this.nickname = nick;
        }

        public void SendMessage(string text) { chatroom.SendMessage(text, this); }
        public void PrintMessage(string text) { WriteLine($"{nickname}: {text}"); }
    }
}
