using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ArithmeticExpressionVisitor2Printer
{

    class Program
    {
        static void Main(string[] args)
        {
            // (1+2)*3-(10/5)

            Numbers a = new() { Value = 1 };
            Numbers b = new() { Value = 2 };
            Numbers c = new() { Value = 3 };
            Numbers d = new() { Value = 10 };
            Numbers e = new() { Value = 5 };

            ArithmeticExpression add = new() { Left = a, Operation = "+", Right = b };
            ArithmeticExpression mult = new() { Left = add, Operation = "*", Right = c };

            ArithmeticExpression div = new() { Left = d, Operation = "/", Right = e };
            ArithmeticExpression sub = new() { Left = mult, Operation = "-", Right = div };

            Console.WriteLine(new Printer(sub));
         



        }
    }
}

