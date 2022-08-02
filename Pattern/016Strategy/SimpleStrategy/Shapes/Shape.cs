using static System.Console;
using SimpleStrategy;

namespace SimpleStrategy.Shapes
{
    abstract class Shape
    {
        readonly AreaInfo method;
        public Shape(AreaInfo method)
        {
            this.method = method;
        }

        public void Area()
        {
            WriteLine(method.Info(this));
        }
        public abstract void Draw();
    }
}
