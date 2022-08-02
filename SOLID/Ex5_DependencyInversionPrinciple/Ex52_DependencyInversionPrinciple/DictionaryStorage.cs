using System.Collections.Generic;

namespace Ex53_DependencyInversionPrinciple
{
    public class DictionaryStorage
    {
        private Dictionary<string, Person> storage;

        public DictionaryStorage()
        {
            storage = new Dictionary<string, Person>();

            Add("SingleResponsibility",
                new Person()
                {
                    LastName = "LastName_1",
                    FirstName = "FirstName_1",
                    Age = 55
                });

            Add("OpenClosed",
                new Person() {
                    LastName = "LastName_2", 
                    FirstName = "FirstName_2", 
                    Age = 33 });

            Add("LiskovSubstitution", 
                new Person() {
                    LastName = "LastName_3", 
                    FirstName = "FirstName_3", 
                    Age = 80 });

            Add("InterfaceSegregation", 
                new Person() {
                    LastName = "LastName_4", 
                    FirstName = "FirstName_4", 
                    Age = 67 });

            Add("DependencyInversion", 
                new Person() {
                    LastName = "LastName_5",
                    FirstName = "FirstName_5",
                    Age = 20 });
        }

        public Dictionary<string, Person> GetPersons() => this.storage;

        public void Add(string key, Person p) => storage.Add(key, p);
    }
}
