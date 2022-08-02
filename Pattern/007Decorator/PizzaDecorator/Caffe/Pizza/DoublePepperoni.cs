using static System.Console;

namespace PizzaDecorator.Caffe.Pizza
{
    class DoublePepperoni : BasePizza
    {
        public override void MakePizza() => WriteLine("DoublePepperoni done...");
    }
}
