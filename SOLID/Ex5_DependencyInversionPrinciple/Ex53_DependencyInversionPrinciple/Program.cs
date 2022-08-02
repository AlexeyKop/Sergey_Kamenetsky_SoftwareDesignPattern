using System;

namespace Ex53_DependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ListStorage: ");

            var storage = new DictionaryStorage();

            new SearchByLastName(storage).Search();
            new SearchByFirstName(storage).Search();
            new SearchByAge(storage).Search();


            Console.WriteLine("ListStorage: ");
            var listStorage = new ListStorage();

            new SearchByLastName(listStorage).Search();
            new SearchByFirstName(listStorage).Search();
            new SearchByAge(listStorage).Search();
        }
    }
}
