namespace ShopFacade.Products
{
    class Candy : IProduct
    {
        string name;
        public Candy(string fruit)
        {
            name = fruit;
        }
        public override string ToString()
        {
            return $"{name}";
        }
    }
}
