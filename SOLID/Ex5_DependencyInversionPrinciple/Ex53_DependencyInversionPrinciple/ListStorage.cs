using System;
using System.Linq;
using System.Collections.Generic;

namespace Ex53_DependencyInversionPrinciple
{
    public class ListStorage : IFindStorage
    {
        private List<Person> storage;

        public ListStorage()
        {
            storage = new List<Person>();
            Add(new Person() { LastName = "LastName_1", FirstName = "FirstName_1", Age = 55 });
            Add(new Person() { LastName = "LastName_2", FirstName = "FirstName_2", Age = 33 });
            Add(new Person() { LastName = "LastName_3", FirstName = "FirstName_3", Age = 80 });
            Add(new Person() { LastName = "LastName_4", FirstName = "FirstName_4", Age = 67 });
            Add(new Person() { LastName = "LastName_5", FirstName = "FirstName_5", Age = 20 });
        }

        public List<Person> GetPersons() => this.storage;

        public void Add(Person p) => storage.Add(p);

        public List<Person> FindAll(Predicate<Person> predicate)
        {
            return storage.Where(e => predicate(e)).ToList();
        }
    }
}
