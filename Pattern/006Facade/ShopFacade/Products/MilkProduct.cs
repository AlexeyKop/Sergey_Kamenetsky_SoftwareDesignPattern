using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopFacade.Products
{
    class MilkProduct : IProduct
    {
        string name;
        public MilkProduct(string milk, int count = 2)
        {
            name = milk;
        }
        public override string ToString()
        {
            return $"{name}";
        }
    }
}
