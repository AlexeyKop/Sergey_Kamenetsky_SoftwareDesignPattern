using ShopFacade.Farmer;
using ShopFacade.Products;
using ShopFacade.Shops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopFacade
{
    class Hypermarket
    {
        FruitsFarmer fruitFarm ;
        MilkFarmer milkFarm;

        List<IProduct> products;

        public Hypermarket()
        {
            products = new List<IProduct>();
            fruitFarm = new FruitsFarmer();
            milkFarm = new MilkFarmer();
        }

        public Hypermarket BuyProduct(string productName)
        {
            IProduct product = productName switch
            {
                "Apple" => fruitFarm.GetFruit("Apple"),
                "Dragon fruit" => fruitFarm.GetFruit("Dragon fruit"),
                "Сheese" => milkFarm.GetMilkProduct("Сheese"),
                "Yogurt" => milkFarm.GetMilkProduct("Yogurt"),
                "Гулливер" => CandyShop.GetCandy("Гулливер"),
                _ => new NullProduct()
            };

            products.Add(product);

            return this;
        }

        public List<IProduct> BuyProduct()
        {
            return products;
        }
    }
}
