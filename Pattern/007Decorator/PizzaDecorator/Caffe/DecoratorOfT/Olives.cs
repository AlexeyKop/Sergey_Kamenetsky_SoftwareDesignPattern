namespace PizzaDecorator.Caffe.DecoratorOfT
{
    public class Olives<T> : Pizza
        where T : Pizza, new()
    {
        private readonly T pizza;
        public Olives() => pizza = new T();
        public override string MakePizza() => $"{pizza.MakePizza()} Olives >> ";
    }
}