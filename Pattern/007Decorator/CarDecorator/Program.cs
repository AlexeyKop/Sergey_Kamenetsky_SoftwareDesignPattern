using CarDecorator.Cars;
using CarDecorator.Decorator.Configurator;
using System;
using System.Reflection;


namespace CarDecorator
{

  
    class Program
    {
        static void Main()
        {

            // видео https://youtu.be/BLSV3B7sp8M

            Audi a6 = new AudiA6();
            Console.WriteLine(a6); // Model: Audi A6 Options: Кресла Двери Price: 15000

            Audi a6Led = new AudiMatrixLed(a6);
            Console.WriteLine(a6Led); // Model: Audi A6 Options: Кресла Двери AudiMatrixLed Price: 15550

            Audi a6AmbientLight = new AudiAmbientLight(a6);
            Console.WriteLine(a6AmbientLight); // Model: Audi A6 Options: Кресла Двери AmbientLight Price: 15250

            Audi a6LedAmbientLight = new AudiAmbientLight(a6Led);
            Console.WriteLine(a6LedAmbientLight); // Model: Audi A6 Options: Кресла Двери AudiMatrixLed AmbientLight Price: 15800

            Console.WriteLine("====");
            Console.WriteLine(a6); // Model: Audi A6 Options: Кресла Двери Price: 15000

            Audi a4f = new AudiColorVesuviusGrayMetallic(
                        new AudiAmbientLight(
                            new AudiMatrixLed(
                                new AudiA4())));
            Console.WriteLine(a4f); // Model: Audi A4 Options: Кресла Двери AudiMatrixLed AmbientLight VesuviusGrayMetallic Price: 12000

            Audi a4s = new AudiMatrixLed(
                        new AudiAmbientLight(
                            new AudiColorVesuviusGrayMetallic(
                                new AudiA4())));
            Console.WriteLine(a4s); // Model: Audi A4 Options: Кресла Двери VesuviusGrayMetallic AmbientLight AudiMatrixLed Price: 12000

            //Model: Audi A6 Options: Кресла Двери Price: 15000
            //Model: Audi A6 Options: Кресла Двери AudiMatrixLed Price: 15550
            //Model: Audi A6 Options: Кресла Двери AmbientLight Price: 15250
            //Model: Audi A6 Options: Кресла Двери AudiMatrixLed AmbientLight Price: 15800
            //====
            //Model: Audi A6 Options: Кресла Двери Price: 15000
            //Model: Audi A4 Options: Кресла Двери AudiMatrixLed AmbientLight VesuviusGrayMetallic Price: 12000
            //Model: Audi A4 Options: Кресла Двери VesuviusGrayMetallic AmbientLight AudiMatrixLed Price: 12000


        }
    }

  


}
