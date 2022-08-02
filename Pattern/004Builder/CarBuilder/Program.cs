using CarBuilder.Builder;
using CarBuilder.Infrastructure;
using System;

namespace CarBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var bulder = Repository.GetBuilder(TypeBuilder.Bolide);
            Engineer engineer = new Engineer(bulder);
            engineer.Produce();
            Console.WriteLine($"Продукт: {bulder.GetResult}");

            bulder = Repository.GetBuilder(TypeBuilder.Motorbike);
            engineer.MainBuilder = bulder;
            engineer.Produce();
            Console.WriteLine($"Продукт: {bulder.GetResult}");

            bulder = Repository.GetBuilder(TypeBuilder.Other);
            engineer.MainBuilder = bulder;
            engineer.Produce();
            Console.WriteLine($"Продукт: {bulder.GetResult}");
        }
    }
}
//Работает BolideBuilder
//Подвеска произведена
//Двигатель для гоночного болида произведён
//Кузов произведён
//Продукт: Транспортное средство<Bolide>

//Работает MotorbikeBuilder
//Подвеска произведена
//Двигатель для мотоцикла произведён
//Кузов произведён
//Продукт: Транспортное средство<Motorbike>

//Работает InternBuilder
//Пока что не научился
//Пока что не научился
//Пока что не научился
//Продукт: Транспортное средство<Skateboard>