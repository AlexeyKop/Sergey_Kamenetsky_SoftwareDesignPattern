using static System.Console;
namespace TemplateMethod.Products
{
    public abstract class Product
    {
        public Product() => WriteLine($"На завтрак {this.GetType().Name}");

        public string Price { get; set; }

        public abstract void KcalOfEnergy();
    }
}
