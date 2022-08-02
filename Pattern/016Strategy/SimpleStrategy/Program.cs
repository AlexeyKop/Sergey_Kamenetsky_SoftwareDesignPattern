using SimpleStrategy.Shapes;
using System.Collections.Generic;
using static System.Console;

namespace SimpleStrategy
{
    class Program
    {
        static void Main()
        {
            var shapes = new List<Shape>
            {
                new Circle(377, 233, 144, new CalculatedArea()),
                new Rectangle(89, 55, 34, 21, new CalculatedArea()),
                new Square(13, 8, 5, new CalculatedArea()),
                new Line(3, 2, 1, 1, new NotCalculatedArea())
            };

            foreach (var shape in shapes)
            {
                shape.Draw();
                shape.Area();
            }
            //Окружность радиусом 144 нарисована в точке 377 233
            //Площадь 65144,07
            //Прямоугольник нарисован из 89 55 размеры 34 x 21
            //Площадь 714
            //Квадрат нарисован из 13 8 размеры 5 ? 5
            //Площадь 25
            //Линия нарисована из 3 2 в 1 1
            //У Line площади нет
        }
    }
}