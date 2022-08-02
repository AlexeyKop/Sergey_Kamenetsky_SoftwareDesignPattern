namespace VirtualProxyIntro
{
    interface IServer
    {
        void AccessGranted(Client user);
        void AccessDenied(Client user);
    }
}
