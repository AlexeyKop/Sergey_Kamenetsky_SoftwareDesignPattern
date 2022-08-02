using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ShopFacade.Products
{
    class Fruit : IProduct
    {
        string name;
        public Fruit(string fruit)
        {
            name = fruit;
        }
        public override string ToString()
        {
            return $"{name}";
        }
    }
}
