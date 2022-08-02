using IntroPrototype.Infrastructure;
using IntroPrototype.Models;
using IntroPrototype.Prototype;
using System;

namespace IntroPrototype
{
    class Program
    {

        class MyClass { }
        struct MyStruct { }

        // применение уже ICloneable, object.MemberwiseClone
        // Прототипно-ориентированное программирование
        static void Main(string[] args)
        {

            // видео https://youtu.be/e4mRDEynnDw

            #region beginner vs lucky

            //MyClass beginner = new MyClass();
            //MyClass youAre = beginner;

            //MyStruct lucky = new MyStruct();
            //MyStruct you = lucky;

            #endregion


            SpecificPrototype obj1 = new SpecificPrototype
            (
                value1: "Первый ",
                value2: Repository.GetValueType,
                value3: Repository.GetReferenceType
            );

            
     
            //>> obj1: Field1: Первый
            //Field2: Data1: 61 Data2: ? Data3 1c884e8a - 5
            //Field3: Data1: 74 Data2: : Data3 01db84c2 - f
            Console.WriteLine($">> obj1: {obj1}");

            Console.WriteLine(new String('─', 50));

            var obj2 = obj1.Clone();
            Console.WriteLine($"obj2: {obj2}");
            
            var obj3 = obj1.Clone();
            
            //obj2: Field1: Первый
            //Field2: Data1: 60 Data2: J Data3 eaacfa67 - d
            //Field3: Data1: 67 Data2: B Data3 fd34fbc2 - d

            Console.WriteLine(new String('─', 50));


            obj1.Field1 = "меняем первого";
            obj1.Field2 = new ValueModel { Data3 = Repository.GetGuid };
            obj1.Field3.Data3 = Repository.GetGuid;

            //>> obj1: Field1: меняем первого
            //Field2: Data1: 0 Data2: Data3 33b86fff - c
            //Field3: Data1: 67 Data2: B Data3 4cfac1e2 - 5
            Console.WriteLine($">> obj1: {obj1}");

            //>> obj2: Field1: Первый
            //Field2: Data1: 60 Data2: J Data3 eaacfa67 - d
            //Field3: Data1: 67 Data2: B Data3 fd34fbc2 - d
            Console.WriteLine($">> obj2: {obj2}");

            //>> obj3: Field1: Первый
            //Field2: Data1: 60 Data2: J Data3 eaacfa67 - d
            //Field3: Data1: 67 Data2: B Data3 fd34fbc2 - d

            Console.WriteLine($">> obj3: {obj3}");

        }
    }
}
