namespace SimpleNoStrategy.Shapes
{
    class Square : Shape
    {
        public double X { get; init; }
        public double Y { get; init; }
        public double Side { get; init; }

        public Square(double x, double y, double side)
        {
            this.X = x;
            this.Y = y;
            this.Side = side;
        }

        // S = Width × Height
        public override void Area()
        {
            WriteLine($"Площадь квадрата: {Pow(Side, 2)}\n");
        }

        public override void Draw()
        {
            WriteLine($"Квадрат нарисован из {X} {Y} размеры {Side} × {Side}");
        }
    }
}
