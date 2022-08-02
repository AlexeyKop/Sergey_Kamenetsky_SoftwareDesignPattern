using static System.Console;

namespace VirtualProxy
{
    class Server : IServer
    {
        public Server() => WriteLine("Сервер создан");

        public void AccessClosed(Client user) => WriteLine($"Доступ закрыт пользователю с ID {user.Id}");

        public void AccessGranted(Client user) => WriteLine($"Доступ предоставлен пользователю с ID {user.Id}");
    }
}
