using static System.Console;

namespace PizzaDecorator.Caffe.Pizza
{
    class Margherita : BasePizza
    {
        public override void MakePizza() => WriteLine("Margherita done...");
    }
}
