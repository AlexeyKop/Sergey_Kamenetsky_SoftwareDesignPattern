using SimpleBridgeV2.Colors;
using System;
using static System.Console;

namespace SimpleBridgeV2.Shapes
{
    class Circle : Shape
    {
        
        private int Radius { get; set; }



        public Circle(Color color,
                        int radius
            )
            : base(color)
        {
            this.Radius = radius;
        }

        public override void Draw()
        {
            WriteLine(
                String.Format("{0} нарисована. Цвет: {1}",
                $"Окружность радиусом {Radius}",
                color
                )
                );
        }
    }

}
