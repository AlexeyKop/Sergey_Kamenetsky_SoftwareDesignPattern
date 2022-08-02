namespace PizzaDecorator.Caffe.Decorator
{
    class FishPizza : Pizza
    {
        Pizza pizza;
        public FishPizza(Pizza pizza)
        {
            this.pizza = pizza;
        }
        public override string MakePizza()
        {
            return pizza.MakePizza() + " MeatPizza ->";
        }
    }





}
