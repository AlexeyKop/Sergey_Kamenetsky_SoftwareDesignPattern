using TemplateMethod.Products;

namespace TemplateMethod.Customers
{
    public abstract class Person
    {
        Product breakfast;

        public abstract Product GetProduct();

        public void ToEat() => breakfast = GetProduct();
    }
}
