using SimpleBridgeV2.Colors;
using System;
using static System.Console;

namespace SimpleBridgeV2.Shapes
{
    class Square : Shape
    {
        public int Side { get; set; }

        public Square(Color color,
                        int side
            )
            : base(color)
        {
            this.Side = side;
        }

        public override void Draw()
        {
            WriteLine(
                String.Format("{0} нарисован. Цвет: {1}",
                $"Квадрат с ребром {Side}",
                color
                )
                );
        }
    }

}
