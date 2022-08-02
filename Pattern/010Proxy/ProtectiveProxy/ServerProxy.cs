using System;
using static System.Console;

namespace VirtualProxy
{
    class ServerProxy : IServer
    {
        private Lazy<Server> server;
        public ServerProxy() { }

        public void AccessGranted(Client client)
        {
            if (server == null) WriteLine($"Неизвестный пользователь");
            else server.Value.AccessGranted(user: client);
        }

        public void Authentication(Client client)
        {
            if (client.Id != "#2021") return;
            WriteLine($"Пользователь известен");
            server = new();
            AccessGranted(client);

        }


        public void AccessClosed(Client client)
        {
            if (server == null) { WriteLine("Аутентификация не пройдена"); return; }
            server.Value.AccessClosed(user: client);
        }
    }
}
