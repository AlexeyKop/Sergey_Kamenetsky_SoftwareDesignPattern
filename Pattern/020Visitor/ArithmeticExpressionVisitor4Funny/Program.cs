using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ArithmeticExpressionVisitor3Calculator
{

    class Program
    {
        static void Main(string[] args)
        {
            // (1+2)*3-(10/5)

            //Numbers a = new() { Value = 1 };
            //Numbers b = new() { Value = 22 };
            //Numbers c = new() { Value = 3 };
            //Numbers d = new() { Value = 100 };
            //Numbers e = new() { Value = 5 };

            //ArithmeticExpression add = new() { Left = a, Operation = "+", Right = b };
            //ArithmeticExpression mult = new() { Left = add, Operation = "*", Right = c };

            //ArithmeticExpression div = new() { Left = d, Operation = "/", Right = e };
            //ArithmeticExpression sub = new() { Left = mult, Operation = "-", Right = div };

            Numbers a = 1;
            Numbers b = 22;
            Numbers c = 3;
            Numbers d = 100;
            Numbers e = 5;

            var res = ((a + b) * c) - (d / e);
            Console.WriteLine(res.PrintExp());
            Console.WriteLine(res.Result());

            //Console.WriteLine($"{new Printer(res)} = {new Calculator(res)}");
        }
    }
}

