using static System.Console;

namespace PizzaDecorator.Caffe.Pizza
{
    class Pepperoni : BasePizza
    {
        public override void MakePizza() => WriteLine("Pepperoni done...");
    }
}
