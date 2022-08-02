namespace VirtualProxy
{
    interface IServer
    {
        void AccessGranted(Client user);
        void AccessClosed(Client user);
    }
}
