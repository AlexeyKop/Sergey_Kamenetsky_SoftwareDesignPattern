using NullObject.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject.Infrastructure
{
    public static class ListProduct
    {
        public static string[] Products { get; }

        static ListProduct()
        {
            Products = new string[]
            {
                "молоко",
                "печеньки",
                "сливки",
                "содовая",
                "кофе",
                "латте",
                "мильфей",
                "какао"
            };
        }
    }
}
