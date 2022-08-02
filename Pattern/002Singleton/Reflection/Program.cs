 using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;

namespace Reflection
{

    class Program
    {
        static void Main()
        {
             

            // Ошибка CS1729  "Foo" не содержит конструктор, который принимает аргументы 0
            // Foo foo = new Foo();
            BindingFlags bf = BindingFlags.NonPublic | BindingFlags.Instance;
            ConstructorInfo[] ctor = typeof(Foo).GetConstructors(bf | BindingFlags.Static);
            FieldInfo[] fields = typeof(Foo).GetFields(bf);
            ConstructorInfo ci = ctor[1];
            ParameterInfo[] pi = ci.GetParameters();
            List<object> args = new List<object>();
            for (int i = 0; i < pi.Length; i++)
            {
                if (pi[i].ParameterType.IsValueType)
                { args.Add(Activator.CreateInstance(pi[i].ParameterType)); }
                else
                {
                    args.Add(pi[i].ParameterType
                          .GetConstructor(bf, null, Type.EmptyTypes, null)
                           .Invoke(null));
                }
            }
            
            Foo f = (Foo)ci.Invoke(args.ToArray());
            Console.WriteLine("\n\ninfo: ");

            foreach (FieldInfo item in fields)
            {
                Console.WriteLine(
                    @"  Name: {0} Type: {1} ", item.Name, item.GetValue(f), item.FieldType);
            }

        }
    }
}
