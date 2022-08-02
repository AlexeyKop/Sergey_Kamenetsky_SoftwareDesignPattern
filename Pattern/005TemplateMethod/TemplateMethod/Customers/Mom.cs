using TemplateMethod.Products;

namespace TemplateMethod.Customers
{
    public class Mom : Person
    {
        public override Product GetProduct() => new Coffe();
    }
}
