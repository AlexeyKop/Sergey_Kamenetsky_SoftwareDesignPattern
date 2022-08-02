namespace VirtualProxyIntro
{
    class ServerProxy : IServer
    {
        private Server server;
        public ServerProxy() => server = new();

        public void AccessDenied(Client client) => server.AccessDenied(user: client);

        public void AccessGranted(Client client) => server.AccessGranted(user: client);
    }
}
