using NullObject.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject.Infrastructure
{
    public class Shop
    {
        public static Product GetProduct(string ofName)
        {
            return ofName.ToLower() switch
            {
                "молоко" or "сливки" => new Milk(),
                "кофе" or "латте" => new Coffe(),
                "мильфей" => new Cake(),
                _ => new UnknownProduct()
            };
        }
    }
}
