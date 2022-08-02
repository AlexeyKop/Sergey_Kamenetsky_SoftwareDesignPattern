namespace SimpleNoStrategy.Shapes
{
    class Circle : Shape
    {
        public double X { get; init; }
        public double Y { get; init; }
        public double R { get; init; }

        public Circle(double x, double y, double r)
        {
            this.X = x;
            this.Y = y;
            this.R = r;
        }

        // S = π * r², где r — это радиус,
        // π — это константа, которая выражает отношение длины окружности к диаметру,
        // она всегда равна 3,14
        public override void Area()
        {
            WriteLine($"Площадь окружности: {PI * Pow(R, 2):#.##}\n");
        }

        public override void Draw()
        {
            WriteLine($"Окружность радиусом {R} нарисована в точке {X} {Y}");
        }
    }
}
