namespace PizzaDecorator.Caffe.DecoratorOfT
{
    public class Pepper<T> : Pizza
        where T : Pizza, new()
    {
        private T pizza;
        public Pepper() => pizza = new T();
        public override string MakePizza() => $"{pizza.MakePizza()} Pepper >>";
    }
}