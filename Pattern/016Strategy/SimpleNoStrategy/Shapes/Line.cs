using System;

namespace SimpleNoStrategy.Shapes
{
    class Line : Shape
    {
        public Line(double x1, double y1, double x2, double y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }

        public double X1 { get; init; }
        public double Y1 { get; init; }
        public double X2 { get; init; }
        public double Y2 { get; init; }

        public override void Area()
        {
            ///???
            throw new Exception("У линии нет площади \n");
        }

        public override void Draw()
        {
            WriteLine($"Линия нарисована из {X1} {Y1} в {X2} {Y2}");
        }
    }
}
