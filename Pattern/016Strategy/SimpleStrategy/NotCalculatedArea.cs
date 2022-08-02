using SimpleStrategy.Shapes;

namespace SimpleStrategy
{
    class NotCalculatedArea : AreaInfo
    {
        public override string Info(Shape shape)
        {
            return $"У {shape.GetType().Name} площади нет";
        }
    }
}