using System;
using System.Collections.Generic;

namespace CompanyFlyweightIntro
{
    class Db
    {
        private static readonly Lazy<Db> instance;
        public static Db Instance { get => instance.Value; }
        static Db() => instance = new Lazy<Db>(() => new Db());

        readonly Dictionary<string, Employee> col;
        private Db() => col = new();
        public Employee GetOrCreateEmployee(string firstName, string lastName)
        {
            var check = col.ContainsKey(firstName);
            if (!check)
            {
                var em = new EmployeeBuilder()
                    .SetFirstName(firstName: firstName)
                    .SetLastName(lastName: lastName)
                    .Build();
                col.Add(firstName, em);
            }
            return col[firstName];
        }
    }
}