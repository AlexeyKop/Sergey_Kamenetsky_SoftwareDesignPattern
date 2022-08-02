using static System.Console;

namespace TemplateMethod.Products
{
    class Cake : Product
    {
        public override void KcalOfEnergy() 
            => WriteLine("Энергетическая ценность 324 ккал");
    }
}
