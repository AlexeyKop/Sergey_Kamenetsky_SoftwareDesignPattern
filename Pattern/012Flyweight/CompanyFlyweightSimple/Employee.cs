using System;
using System.Linq;

namespace CompanyFlyweightSimple
{
    class Employee
    {
        private readonly IRepository repo;

        private int GetOrCreate(string characteristic)
        {
            int index = repo.Read(characteristic);
            if (index == -1)
            {
                repo.Create(characteristic);
                return repo.Read(characteristic, true);
            }
            return index;
        }


        public Employee(string fullInfo, IRepository repository)
        {
            repo = repository;
            characteristics = fullInfo.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                   .Select(GetOrCreate)
                                   .ToArray();
        }

        private readonly int[] characteristics;

        public override string ToString() => String.Join(" ", characteristics.Select(e => repo.Read(e)));
    }
}