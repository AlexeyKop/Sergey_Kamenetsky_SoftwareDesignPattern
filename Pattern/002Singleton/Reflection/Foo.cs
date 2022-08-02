using System;

namespace Reflection
{
    class Foo
    {
        static Foo() { }
        private Foo(int prop) 
        {
            Console.WriteLine($"prop: {prop}");
            MyProperty1 = 82;
            MyProperty2 = "90";
            MyProperty3 = 23.1;

            myField1 = 28;
            myField2 = "09";
            myField3 = 1.32;
        }
        private Foo(int prop, uint field) { }

        private int MyProperty1 { get; set; } 
        private string MyProperty2 { set => myField2 = value; }
        private double MyProperty3 { get; }

        int myField1;
        private string myField2;
        private double myField3;
    }
}
