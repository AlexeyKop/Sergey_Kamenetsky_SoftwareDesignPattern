using System;

namespace NullObject.Products
{
    public class Coffe : Product
    {
        public Coffe()
           : base(energy: 78, "Little's Franch Vanilla")
        { }
        public override void Eat() => Console.WriteLine("Кофе, какой  он есть!");
    }
}
