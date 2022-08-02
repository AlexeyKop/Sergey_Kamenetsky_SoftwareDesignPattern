using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject.Products
{
    public class UnknownProduct : Product
    {
        public UnknownProduct()
           : base(energy: 0, "Неизвестный продукт")
        { }

        public override void Eat()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вероятно у вас голодание. Продукта не обнаружено");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
