using System;

namespace NullObject.Products
{
    public class Milk : Product
    {
        public Milk()
            : base(energy: 324, "Parmalat 0.05%")
        { }

        public override void Eat() =>  Console.WriteLine("Молочко... Ммм вкусно!");
    }
}
