using System;
using System.Linq;

namespace Ex53_DependencyInversionPrinciple
{
    public class SearchByLastName
    {
        ListStorage storage;
        public SearchByLastName(ListStorage storage) => this.storage = storage;

        public void Search()
        {
            foreach (var p in storage.GetPersons()
                                        .Where(e => e.LastName.Contains("_")))
            {
                Console.WriteLine($"{p.FirstName.Substring(0,4)}...");
            }
            Console.WriteLine();
        }
    }


}
