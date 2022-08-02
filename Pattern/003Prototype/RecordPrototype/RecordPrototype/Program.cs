using System;
using System.Collections.Generic;

namespace RecordPrototype
{
    class Program
    {

        //public record TaggedNumber(int Number, List<string> Tags)
        //{
        //    public string PrintTags() => string.Join(", ", Tags);
        //}

        //public static void Main()
        //{
        //    var original = new TaggedNumber(1, new List<string> { "A", "B" });

        //    var copy = original with { Number = 2 };
        //    Console.WriteLine($"Tags of {nameof(copy)}: {copy.PrintTags()}");
        //    // output: Tags of copy: A, B

        //    original.Tags.Add("C");
        //    Console.WriteLine($"Tags of {nameof(copy)}: {copy.PrintTags()}");
        //    // output: Tags of copy: A, B, C
        //}


        static void Main(string[] args)
        {
            Car car = new Car("Audi", "RS5", 111, 222, 333);

            var newCar = car with { Brand = "Lada" };

            Console.WriteLine($"car    - {car}"); // Brand: Audi Model: RS5 [111 222 333]
            Console.WriteLine($"newCar - {newCar}"); // Brand: Lada Model: RS5 [111 222 333]

            car.Brand = "BMW";
            car.Model = new ModelCar() { Name = "M3" };
            car.Size[1] = 0;
            Console.WriteLine($"car    - {car} "); // Brand: BMW Model: M3 [111 0 333]
            Console.WriteLine($"newCar - {newCar}"); // Brand: Lada Model: RS5 [111 0 333]

        }
    }
}
