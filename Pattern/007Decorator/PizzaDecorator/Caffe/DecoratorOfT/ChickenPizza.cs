namespace PizzaDecorator.Caffe.DecoratorOfT
{
    public sealed class ChickenPizza : Pizza
    {
        public override string MakePizza() => $"ChickenPizza >> ";
    }
}