using static System.Console;

namespace TemplateMethod.Products
{
    class Coffe : Product
    {
        public override void KcalOfEnergy()
            => WriteLine("Энергетическая ценность 2 ккал"); 
    }
}
