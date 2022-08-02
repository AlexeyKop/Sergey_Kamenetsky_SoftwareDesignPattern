using System;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization.Formatters.Binary;

namespace TruePrototype
{

    public class Program
    {
        static void Main(string[] args)
        {
            var address = new Address
            {
                City = new City
                {
                    street = new Street
                    {
                        House = new House { HouseNumber = 123 }
                    }
                }
            };


            Address newAddress = ObjectCloneable.DeepCloneable(address);

            newAddress.City.street.House.HouseNumber = 22990;

            Address jAdress = ObjectCloneable.DeepCloneable<Address>(address);
            
            Address jAdress2 = address.DeepCloneable();

            jAdress2.City.street.House.HouseNumber = 1408;

            jAdress.City = new City { street = new Street { House = new House { HouseNumber = 12345 } } };

            Console.WriteLine($"jAdress: {jAdress.City.street.House.HouseNumber}");
            Console.WriteLine($"jAdress2: {jAdress2.City.street.House.HouseNumber}");
            Console.WriteLine($"newAddress: {newAddress.City.street.House.HouseNumber}");
            Console.WriteLine($"address: {address.City.street.House.HouseNumber}");

        }

        class MyClass
        {
            public int MyProperty { get; set; }
        }
        record GG 
        {
            public int qqq { get; set; }
            public MyClass www { get; set; }
        }

    }
}