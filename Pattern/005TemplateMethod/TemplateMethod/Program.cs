using TemplateMethod.Customers;
using System;
using System.Collections.Generic;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> family = new List<Person>()
            {
                new Daughter(),
                new Mom(),
                new Dad(),
            };

            foreach (var e in family)           // На завтрак Milk
            {                                   // На завтрак Coffe
                e.ToEat();                      // На завтрак Cake
            }

        }
    }
}
