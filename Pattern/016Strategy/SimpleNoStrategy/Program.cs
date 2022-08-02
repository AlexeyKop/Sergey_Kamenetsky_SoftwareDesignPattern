using SimpleNoStrategy.Shapes;
using System;
using System.Collections.Generic;
using static System.Console;
using static System.Math;

namespace SimpleNoStrategy
{
    class Program
    {
        static void Main()
        {
            var shapes = new List<Shape>
            {
                new Circle(377, 233, 144),
                new Rectangle(89, 55, 34, 21),
                new Square(13, 8, 5),
                new Line(3, 2, 1, 1)
            };

            foreach (var shape in shapes)
            {
                shape.Draw();
                shape.Area();
            }
        }
    }
}