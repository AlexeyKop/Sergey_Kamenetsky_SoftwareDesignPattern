using SimpleBridgeV2.Colors;
using System;
using static System.Console;

namespace SimpleBridgeV2.Shapes
{
    class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(Color color,
                        int width,
                        int height
            )
            : base(color)
        {
            this.Height = height;
            this.Width = width;
        }

        public override void Draw()
        {
            WriteLine(
                String.Format("{0} нарисован. Цвет: {1}",
                $"Прямоугольник {Width} x {Height}",
                color
                )
                );
        }
    }

}
