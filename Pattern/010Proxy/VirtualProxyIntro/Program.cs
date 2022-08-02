using static System.Console;

namespace VirtualProxy
{
    class Program
    {
        static void Main()
        {
            Client client = new();

            WriteLine(" Server server = new();");
            
            Server server = new();
            //Сервер создан

            
            server.AccessGranted(user: client);
            server.AccessDenied(user: client);

            WriteLine("\n\nServerProxy proxy = new();");

            ServerProxy proxy = new();
            proxy.AccessGranted(client: client);
            proxy.AccessDenied(client: client);
        }
    }
}
