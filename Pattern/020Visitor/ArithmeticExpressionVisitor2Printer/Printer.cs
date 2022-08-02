using System;
using System.Text;

namespace ArithmeticExpressionVisitor2Printer
{
    class Printer
    {
        StringBuilder sb;
        Node exp;
        Random rand;
        public Printer(Node expression)
        {
            exp = expression;
            sb = new StringBuilder();
            rand = new Random();
        }

        private void Print(Node node)
        {
            if (node is Numbers n) sb.Append(n.Value);
            else if (node is ArithmeticExpression op)
            {
                (string open, string closed) bracket = rand.Next(3) switch
                {
                    0 => ("(", ")"),
                    1 => ("{", "}"),
                    _ => ("[", "]")
                };

                sb.Append(bracket.open);
                Print(op.Left);
                sb.Append(op.Operation);
                Print(op.Right);
                sb.Append(bracket.closed);
            }
        }
        public override string ToString()
        {
            sb.Clear();
            Print(exp);
            return  sb.ToString();
        }
}
}

