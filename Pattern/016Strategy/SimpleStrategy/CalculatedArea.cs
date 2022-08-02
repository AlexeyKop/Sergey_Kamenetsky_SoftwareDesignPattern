using SimpleStrategy.Shapes;
using System;
using static System.Math;

namespace SimpleStrategy
{
    class CalculatedArea : AreaInfo
    {
        public override string Info(Shape shape)
        {
            string format = "Площадь {0}";
            double value;
            if (shape is Circle) { var c = shape as Circle; value = PI * Pow(c.R, 2); }
            else if (shape is Rectangle) { var c = shape as Rectangle; value = c.Width * c.Height; }
            else { var c = shape as Square; value = c.Side * c.Side; }

            return String.Format(format, value.ToString("#.##"));
        }
    }
}