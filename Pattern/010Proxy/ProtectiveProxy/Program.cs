using System;

namespace VirtualProxy
{
    class Program
    {
        static void Main()
        {
            Client client = new();

            
            ServerProxy proxy = new();
            proxy.AccessGranted(client: client);
            proxy.AccessClosed(client: client);

            Console.WriteLine("\n\nproxy.Authentication(client);");
            proxy.Authentication(client);

            Console.WriteLine("\n\nproxy.AccessGranted(client: client);");
            proxy.AccessGranted(client: client);

            Console.WriteLine("\n\nproxy.AccessClosed(client: client);");
            proxy.AccessClosed(client: client);
        }
    }
}
