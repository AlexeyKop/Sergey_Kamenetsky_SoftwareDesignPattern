namespace SimpleNoStrategy.Shapes
{
    class Rectangle : Shape
    {
        public double X { get; init; }
        public double Y { get; init; }
        public double Width { get; init; }
        public double Height { get; init; }

        public Rectangle(double x, double y, double width, double height)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
        }

        // S = Width × Height
        public override void Area()
        {
            WriteLine($"Площадь прямоугольника: {Width * Height}\n");
        }

        public override void Draw()
        {
            WriteLine($"Прямоугольник нарисован из {X} {Y} размеры {Width} x {Height}");
        }
    }
}
