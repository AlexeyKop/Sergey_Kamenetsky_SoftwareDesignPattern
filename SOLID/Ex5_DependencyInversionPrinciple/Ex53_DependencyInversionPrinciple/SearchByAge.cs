using System;
using System.Linq;

namespace Ex53_DependencyInversionPrinciple
{
    public class SearchByAge
    {
        IFindStorage storage;

        public SearchByAge(IFindStorage storage) => this.storage = storage;

        public void Search()
        {
            foreach (var p in storage.FindAll(e => e.Age > 45))
            {
                Console.WriteLine($"{p.FirstName} {p.Age}");
            }
            Console.WriteLine();
        }
    }


}
