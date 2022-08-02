using TemplateMethod.Products;

namespace TemplateMethod.Customers
{
    public class Dad : Person
    {
        public override Product GetProduct() => new Cake();
    }
}
