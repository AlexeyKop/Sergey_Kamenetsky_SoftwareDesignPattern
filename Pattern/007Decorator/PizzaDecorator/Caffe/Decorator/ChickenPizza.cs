namespace PizzaDecorator.Caffe.Decorator
{
    class ChickenPizza : Pizza
    {
        Pizza pizza;
        public ChickenPizza(Pizza pizza)
        {
            this.pizza = pizza;
        }
        public override string MakePizza()
        {
            return pizza.MakePizza() + " ChickenPizza ->";
        }
    }
}
