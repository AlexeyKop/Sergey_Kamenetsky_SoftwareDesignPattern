using static System.Console;

namespace TemplateMethod.Products
{
    public class Milk : Product
    {
        public override void KcalOfEnergy() 
            => WriteLine("Энергетическая ценность 60 ккал");
    }
}
