using System;
using System.Collections.Generic;
using System.Linq;

namespace ExpressionAnalyzer
{
    public class Symbol 
    {
        public virtual int Value { get;  init; }
    }
    public class Integer : Symbol
    {
        public Integer(int value)
        {
            base.Value = value;
        }
    }
    public class ArithmeticOperationExpression : Symbol
    {
        public string Operation { get; set; }
        public Symbol Left { get; set; }
        public Symbol Right { get; set; }

        public override int Value
        {
            get
            {
                switch (Operation)
                {
                    case "+": return Left.Value + Right.Value;
                    case "-": return Left.Value - Right.Value;
                    case "/": return Left.Value / Right.Value;
                    case "*": return Left.Value * Right.Value;
                    default: throw new ArithmeticException("NotImplementedException");
                }

            }
        }
    }
   
    public enum TypeList
    {
        Operation,
        Integer
    }
    
    public class Token
    {
        public Token(string text, TypeList type)
        {
            Text = text;
            MyType = type;
        }

        public string Text { get; set; }
        public TypeList MyType { get; set; }

        public override string ToString() => $"[{Text}]";
    }
    
    public static class Tokinizer
    {
        public static List<Token> GetTokens(string input)
        {
            var res = new List<Token>();

            var inp = input.Split(' ');

            foreach (var item in inp)
            {
                switch (item)
                {
                    case "+": res.Add(new Token("+", TypeList.Operation)); break;
                    case "-": res.Add(new Token("-", TypeList.Operation)); break;
                    case "/": res.Add(new Token("/", TypeList.Operation)); break;
                    case "*": res.Add(new Token("*", TypeList.Operation)); break;
                    default: res.Add(new Token(item, TypeList.Integer)); break;
                }
            }
            return res;
        }
    }
    public class Parser
    {
        public static Symbol Parse(List<Token> tokens)
        {
            var result = new ArithmeticOperationExpression();
            bool f = false;
            foreach (var item in tokens)
            {
                switch (item.MyType)
                {
                    case TypeList.Operation:
                        result.Operation = item.Text;
                        break;

                    case TypeList.Integer:
                        Integer n = new(int.Parse(item.Text));
                        if (!f)
                        {
                            result.Left = n;
                            f = true;
                        }
                        else { result.Right = n; }
                        break;
                }
            }
            return result;
        }
    }
    class Program
    {
        static void Main()
        {
            var exp = Tokinizer.GetTokens("1023 - 22");
            foreach (var item in exp)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine(Parser.Parse(exp).Value);
        }
    }
}
