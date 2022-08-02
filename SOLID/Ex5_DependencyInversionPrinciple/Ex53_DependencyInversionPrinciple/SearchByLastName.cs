using System;
using System.Linq;

namespace Ex53_DependencyInversionPrinciple
{
    public class SearchByLastName
    {
        IFindStorage storage;
        public SearchByLastName(IFindStorage storage) => this.storage = storage;

        public void Search()
        {
            foreach (var p in storage.FindAll(e => e.LastName.Contains("_")))
            {
                Console.WriteLine($"{p.FirstName} {p.Age}");
            }
            Console.WriteLine();
        }
    }
}
