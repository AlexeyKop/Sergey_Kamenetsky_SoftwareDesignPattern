using SimpleBridgeV2.Colors;
using SimpleBridgeV2.Shapes;
using System.Collections.Generic;
using static System.Console;

namespace SimpleBridgeV2
{
    class Program
    {
        static void Main()
        {
            List<Shape> shapes = new()
            {
                new Circle(new RedColor(), 10),
                new Circle(new GreenColor(), 10),
                new Rectangle(new RedColor(), 10, 20),
                new Rectangle(new YellowColor(), 10, 20),
                new Rectangle(new YellowColor(), 10, 5),
                new Square(new RedColor(), 5),
            };

            foreach (var shape in shapes) shape.Draw(); 
        }
    }
}
