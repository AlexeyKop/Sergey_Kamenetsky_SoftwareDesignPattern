using ExceptionObject.Exceptions;
using NullObject.Products;
using System;

namespace ExceptionObject.Infrastructure
{
    public class Stall
    {
        public static Product GetProduct(string ofName) =>
            ofName.ToLower() switch
            {
                "молоко" or "сливки" => new Milk(),
                "кофе" or "латте" => new Coffe(),
                "мильфей" => new Cake(),
                //_ => null
                //_ => throw new Exception("Нет такого продукта")
                _ => throw new ProductNotFoundException()
            };
    }
}
