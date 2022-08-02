using System;

namespace AddressBuilderClassic
{

    class Program
    {
        static void Main()
        {
            Address addres = new AddressBuilder()
                .SetCountry("РФ")
                .SetCity("Москва")
                .SetStreet("Ленина")
                .SetHouse("123k4")
                .SetNumber("56")
                .Build();

            Console.WriteLine(addres); // РФ Москва Ленина 123k4 56

            Console.WriteLine();
            addres = new AddressBuilder()
                .SetCountry("РФ")
                .SetHouse("123k4")
                .SetHouse("123k4")
                .SetCity("Москва")
                .SetCity("Москва")
                .SetCity("Москва")
                .SetStreet("Ленина")
                .SetHouse("123k4")
                .SetHouse("123k4")
                .SetHouse("123k4")
                .SetNumber("56")
                .Build();

            Console.WriteLine(addres); // РФ Москва Ленина 123k4 56
        }
    }
}