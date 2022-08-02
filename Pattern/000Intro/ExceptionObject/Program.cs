using ExceptionObject.Exceptions;
using ExceptionObject.Infrastructure;
using NullObject.Infrastructure;
using NullObject.Products;
using System;

namespace ExceptionObject
{
    class Program
    {
        static void Main()
        {
            #region _ => null

            //foreach (string productName in ListProduct.Products)
            //{
            //    Product product = Stall.GetProduct(productName);
            //    if (product != null)
            //    {
            //        Console.WriteLine(product.KcalOfEnergy);
            //        product.Eat();
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region _ => null ?.

            foreach (string productName in ListProduct.Products)
            {
                Product product = Stall.GetProduct (productName);
                Console.WriteLine (product?.KcalOfEnergy);
                product?.Eat ( );
                Console.WriteLine ( );
            }

            #endregion

            #region _ => throw new Exception("Нет такого продукта")

            //foreach (string productName in ListProduct.Products)
            //{
            //    try
            //    {
            //        Product product = Stall.GetProduct(productName);

            //        Console.WriteLine(product.KcalOfEnergy);
            //        product.Eat();

            //        Console.WriteLine();
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine($"   >>> {ex.Message}");
            //    }
            //}

            #endregion

            #region _ => throw new ProductNotFoundException()

            foreach (string productName in ListProduct.Products)
            {
                try
                {
                    Product product = Stall.GetProduct(productName);

                    Console.WriteLine(product.KcalOfEnergy);
                    product.Eat();

                    Console.WriteLine();
                }
                catch (ProductNotFoundException ex)
                {
                    Console.WriteLine($"   >>> {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"   >>> Ещё ошибка {ex.Message}");
                }
            }

            #endregion

        }
    }
}