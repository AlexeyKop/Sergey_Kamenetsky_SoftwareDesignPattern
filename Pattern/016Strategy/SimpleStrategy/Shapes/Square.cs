using static System.Console;

namespace SimpleStrategy.Shapes
{
    class Square : Shape
    {
        public double X { get; init; }
        public double Y { get; init; }
        public double Side { get; init; }

        public Square(double x, double y, double side, AreaInfo method)
            : base(method)
        {
            this.X = x;
            this.Y = y;
            this.Side = side;
        }

        public override void Draw()
        {
            WriteLine($"Квадрат нарисован из {X} {Y} размеры {Side} × {Side}");
        }
    }
}
