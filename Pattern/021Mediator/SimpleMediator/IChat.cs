namespace SimpleMediator
{
    interface IChat
    {
        void SendMessage(string message, User user);
        void AppendUser(User user);
    }
}
