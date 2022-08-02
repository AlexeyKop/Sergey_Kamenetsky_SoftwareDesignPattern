using static System.Console;

namespace SimpleStrategy.Shapes
{
    class Circle : Shape
    {
        public double X { get; init; }
        public double Y { get; init; }
        public double R { get; init; }

        public Circle(double x, double y, double r, AreaInfo method)
            : base(method)
        {
            this.X = x;
            this.Y = y;
            this.R = r;
        }

        public override void Draw()
        {
            WriteLine($"Окружность радиусом {R} нарисована в точке {X} {Y}");
        }
    }
}
