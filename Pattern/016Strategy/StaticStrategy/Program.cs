using StaticStrategy.FileProvider;
using System;
using System.Collections.Generic;
using static System.Console;

namespace StaticStrategy
{


    class Program
    {
        static void Main()
        {
            var id = new Dictionary<string, string>()
            {
                ["FName"] = "Sergey",
                ["LName"] = "Kam",
                ["Age"] = "30",
            };

            Document<Json> doc = new();

            doc.AppendAll(id)
               .Append("description", "thanks for watching");
            WriteLine(doc.Save());
        }
    }
}
