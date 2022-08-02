using static System.Console;

namespace PizzaDecorator.Caffe.Decorator
{

    class Cheese : Pizza
    {
        Pizza pizza;
        public Cheese(Pizza pizza)
        {
            this.pizza = pizza;
        }
        public override string MakePizza()
        {
            return pizza.MakePizza() + " Cheese ->";
        }
    }

}
