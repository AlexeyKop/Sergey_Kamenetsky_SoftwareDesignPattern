using System;
using NullObject.Infrastructure;
using NullObject.Products;

namespace NullObject
{
    class Program
    {
        static void Main()
        {
            foreach (string productName in ListProduct.Products)
            {
                Product product = Shop.GetProduct(productName);
                Console.WriteLine(product.KcalOfEnergy);
                product.Eat();
                Console.WriteLine();
            }


        }
    }
}