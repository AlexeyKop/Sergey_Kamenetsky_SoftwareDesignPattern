using System;

namespace VirtualProxy
{
    class ServerProxy : IServer
    {
        private Lazy<Server> server;
        public ServerProxy() => server = new(() => new Server());

        public void AccessDenied(Client client) => server.Value.AccessDenied(user: client);

        public void AccessGranted(Client client) => server.Value.AccessGranted(user: client);
    }
}
