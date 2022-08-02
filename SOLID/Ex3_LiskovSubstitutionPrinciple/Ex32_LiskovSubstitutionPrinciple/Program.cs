using System;

namespace Ex32_LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird();

            CalculatingDistance dist = new CalculatingDistance(10);

            dist.Calculate(bird);

            Console.ReadLine();
            Console.Clear();

            Kiwi kiwi = new Kiwi();
            dist = new CalculatingDistance(10);

            dist.Calculate(kiwi);

            Console.ReadLine();
        }
    }
}
