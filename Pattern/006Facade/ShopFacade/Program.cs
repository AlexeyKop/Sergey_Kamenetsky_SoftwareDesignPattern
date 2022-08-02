using ShopFacade.Clients;
using System;

namespace ShopFacade
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();
            Console.WriteLine(client.ProductList());
            client.TripHypermarket();

            Console.WriteLine(client.ProductList());


        }
    }
}
