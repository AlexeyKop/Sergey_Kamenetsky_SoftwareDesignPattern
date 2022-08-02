using System.Collections.Generic;

namespace CompanyFlyweightSimple
{
    class Repository : IRepository
    {
        public static List<string> data;
        static Repository() => data = new List<string>();

        public void Create(string value) => data.Add(value);

        public int Read(string value, bool last) =>
            last ? data.LastIndexOf(value) : data.IndexOf(value);

        public string Read(int index) => data[index];
    }
}