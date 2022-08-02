using ShopFacade.Farmer;
using ShopFacade.Products;
using ShopFacade.Shops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopFacade.Clients
{
    class Client
    {
        List<IProduct> basket;

        public Client()
        {
            basket = new List<IProduct>();
        }
        public void Purchases()
        {
            FruitsFarmer fruitFarm = new FruitsFarmer();
            basket.Add(fruitFarm.GetFruit("Apple"));
            basket.Add(fruitFarm.GetFruit("Dragon fruit"));

            MilkFarmer milkFarm = new MilkFarmer();
            basket.Add(milkFarm.GetMilkProduct("Сheese"));
            basket.Add(milkFarm.GetMilkProduct("Yogurt"));

            basket.Add(CandyShop.GetCandy("Гулливер"));
        }

        public string ProductList()
        {
            return $"My purchases: {String.Join(", ", basket)}";
        }

        public void TripHypermarket()
        {
            basket = new Hypermarket()
                .BuyProduct("Apple")
                .BuyProduct("Сheese")
                .BuyProduct("Yogurt")
                .BuyProduct("Гулливер")
                .BuyProduct();
        }
    }
}
