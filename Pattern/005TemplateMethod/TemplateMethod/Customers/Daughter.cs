using TemplateMethod.Products;

namespace TemplateMethod.Customers
{
    public class Daughter : Person
    {
        public override Product GetProduct() => new Milk();
    }
}
