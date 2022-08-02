namespace PizzaDecorator.Caffe.Decorator
{
    class MeatPizza : Pizza
    {
        Pizza pizza;
        public MeatPizza(Pizza pizza)
        {
            this.pizza = pizza;
        }
        public override string MakePizza()
        {
            return pizza.MakePizza() + " MeatPizza ->";
        }
    }





}
