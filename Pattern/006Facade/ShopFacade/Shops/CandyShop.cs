using ShopFacade.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopFacade.Shops
{
    static class CandyShop
    {
        static public Candy GetCandy(string name)
        {
            return new Candy(name);
        }
    }
}
