using static System.Console;

namespace VirtualProxyIntro
{
    class Server : IServer
    {
        public Server() => WriteLine("Сервер создан");

        public void AccessDenied(Client user) => WriteLine($"Доступ запрещён пользователю с ID {user.Id}");

        public void AccessGranted(Client user) => WriteLine($"Доступ предоставлен пользователю с ID {user.Id}");
    }
}
