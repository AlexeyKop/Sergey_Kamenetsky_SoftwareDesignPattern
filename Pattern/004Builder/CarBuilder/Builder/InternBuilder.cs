using CarBuilder.Car;
using System;

namespace CarBuilder.Builder
{
    class InternBuilder : AbstractBuilder
    {
        Skateboard skateboard;
        public InternBuilder() { skateboard = new Skateboard(); }
        public override Vehicle GetResult { get { return skateboard; } }


        public override void MakeBody() { skateboard.AddPart(new NullUnit()); }
        //Console.WriteLine("Колёсики нашёл. Погнали");

        public override void MakeEngine() { skateboard.AddPart(new NullUnit()); }
        //Console.WriteLine("Двигатель - это сложно. Колёсики к доске привинтил");

        public override void MakeSuspension() { skateboard.AddPart(new NullUnit()); }
        //Console.WriteLine("Что умею - то и строю");
    }
}
