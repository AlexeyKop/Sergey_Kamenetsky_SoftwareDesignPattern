using System;
using System.Linq;

namespace Ex53_DependencyInversionPrinciple
{
    public class SearchByFirstName
    {
        DictionaryStorage storage;
        public SearchByFirstName(DictionaryStorage storage) => this.storage = storage;

        public void Search()
        {
            //foreach (var p in storage.GetPersons()
            //                         .Where(e => e.FirstName.Contains("Name_3")))
            //{
            //    Console.WriteLine($"{p.FirstName} {p.LastName}");
            //}
            //Console.WriteLine();
        }
    }


}
