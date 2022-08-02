using SimpleBridgeV2.Colors;

namespace SimpleBridgeV2.Shapes
{
    abstract class Shape
    {
        protected Color color;
        protected Shape(Color color) => this.color = color;
        public abstract void Draw();
    }

}
