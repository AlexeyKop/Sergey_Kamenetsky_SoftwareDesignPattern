using ShopFacade.Products;

namespace ShopFacade.Farmer
{
    class MilkFarmer
    {
        public MilkProduct GetMilkProduct(string name)
        {
            return new MilkProduct(name);
        }
    }


}
