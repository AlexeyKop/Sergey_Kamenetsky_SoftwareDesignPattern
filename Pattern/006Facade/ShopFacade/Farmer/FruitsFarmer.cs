using ShopFacade.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopFacade.Farmer
{

    class FruitsFarmer
    {
        public Fruit GetFruit(string fruitName)
        {
            return new Fruit(fruitName);
        }
    }



}
