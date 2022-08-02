using System;

namespace AddressBuilder
{

    class Program
    {
        static void Main(string[] args)
        {

            // Видео https://youtu.be/86LofUIbHgw

            AddressBuilder addressBuilder1 =
               AddressBuilder
               .Build("Адрес", "Рабочий адрес")
               .AddItem("индекс", "214000")
               .AddItem("страна", "РФ")
               .AddItem("область", "Смоленская")
               .AddItem("город", "Смоленск")
               .AddItem("улица", "Пржевальского")
               .AddItem("дом", "4")
               .AddItem("корпус", "2")
               .AddItem("Получатель", "Ваня");

            Console.WriteLine(addressBuilder1);
            Console.WriteLine();
            AddressBuilder addressBuilder = AddressBuilder.Build("Адрес", "Рабочий адрес")
            .AddItem("город", "Смоленск")
            .AddItem("улица", "Пржевальского")
            .AddItem("дом", "4").AddItem("дом", "4")
            .AddItem("индекс", "214000")
            .AddItem("страна", "РФ")
            .AddItem("дом", "4")
            .AddItem("дом", "4")
            .AddItem("область", "Смоленская")
            .AddItem("корпус", "2")
            .AddItem("Получатель", "Ваня");

            Console.WriteLine(addressBuilder);

        }
    }
}
