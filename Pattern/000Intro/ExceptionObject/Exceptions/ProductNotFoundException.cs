using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionObject.Exceptions
{
    public class ProductNotFoundException : Exception
    {
        public ProductNotFoundException()
            : base("Такого продукта нет")
        { }
    }
}
