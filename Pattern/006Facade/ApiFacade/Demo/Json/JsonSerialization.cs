using ApiFacade.Demo;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ApiFacade.Json
{
    public class JsonSerialization
    {
        public static void Deno()
        {
            JsonSerialization s = new JsonSerialization();

            var wrk = new Worker
            {
                FirstName = "Имя",
                LastName = "Фамилия",
                Age = 30,
                Salary = 2000
            };
            Console.WriteLine(s.Serialize(wrk));
            //{
            //"LastName": "Фамилия",
            //"Salary": 2000,
            //"FirstName": "Имя",
            //"Age": 30
            //}
            Console.WriteLine();


            string jsonWrk = "{\"LastName\": \"Фамилия Работника\",\"Salary\": 21000," +
                "\"FirstName\": \"Имя Работника\",\"Age\": 33}";

            Worker w = s.Deserialize<Worker>(jsonWrk);

            Console.WriteLine(w.LastName); // Фамилия Работника
            Console.WriteLine(w.Age); // 33
            Console.WriteLine(w.FirstName); // Имя Работника
            Console.WriteLine(w.Salary); // 21000


            //TelegramNotApi.GetUpdates(TelegramData.Token);
        }
        public T Deserialize<T>(string json)
            where T: new()
        {
            var r = json//.Replace(",", "\n")
                       .Replace("{", "")
                       .Replace("}", "")
                       .Replace("\n\n", "\n")
                       .Split(',');

            T obj = new();
            Type type = obj.GetType();

            foreach (var item in r)
            {
                var pair = item.Trim().Split(':');

                var pofname= pair[0].Replace("\"", "");
                var val = pair[1].Trim().Replace("\"","");

                FieldInfo field = type.GetField(pofname);
                PropertyInfo property = type.GetProperty(pofname);

                if (field != null)
                {
                    if (field.FieldType != typeof(Int32)) { field.SetValue(obj, val); }
                    else { field.SetValue(obj, int.Parse(val)); }
                }
                else
                {
                    if (property.PropertyType != typeof(Int32)) { property.SetValue(obj, val); }
                    else { property.SetValue(obj, int.Parse(val)); }
                }

            }
            return obj;
        }
        public string Serialize<T>(T obj)
        {
            Type type = obj.GetType();
            string s = "{\n";
            var r = type.GetFields();
            if (r.Length != 0)
            {
                foreach (var item in r)
                {
                    if (item.FieldType == typeof(Int32))
                    {
                        s += $"\"{item.Name}\": {item.GetValue(obj)},\n";
                    }
                    else
                    {
                        s += $"\"{item.Name}\": \"{item.GetValue(obj)}\",\n";
                    }
                }
                s = s.Substring(0, s.Length - 1);
                s += "\n}";
            }
            var d = type.GetProperties();
            if (d.Length != 0)
            {
                s = s.Substring(0, s.Length - 1);
                foreach (var item in d)
                {
                    if (item.PropertyType == typeof(Int32))
                    {
                        s += $"\"{item.Name}\": {item.GetValue(obj)},\n";
                    }
                    else
                    {
                        s += $"\"{item.Name}\": \"{item.GetValue(obj)}\",\n";
                    }
                }
                s = s.Substring(0, s.Length - 2);
                s += "\n}";
            }
            return s;
        }
    }
}
