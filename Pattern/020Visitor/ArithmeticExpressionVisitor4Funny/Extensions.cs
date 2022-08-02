using System.Text;

namespace ArithmeticExpressionVisitor3Calculator
{
    static class Extensions
    {
        static private void Print(Node node, StringBuilder sb)
        {
            if (node is Numbers n) sb.Append(n.Value);
            else if (node is ArithmeticExpression op)
            {
                sb.Append("(");
                Print(op.Left, sb);
                sb.Append(op.Operation);
                Print(op.Right, sb);
                sb.Append(")");
            }
        }

        static public void Calc(Node node, ref int res)
        {
            if (node is Numbers n) { res = n.Value; }
            else if (node is ArithmeticExpression op)
            {
                int left = 0;
                Calc(op.Left, ref left);
                int right = 0;
                Calc(op.Right, ref right);
                res = op.Operation switch
                {
                    "+" => left + right,
                    "-" => left - right,
                    "*" => left * right,
                    _ => left / right,
                };
            }
        }

        public static int Result(this Node node)
        {
            int result = 0;
            Calc(node, ref result);
            return result;
        }

        public static string PrintExp(this Node node)
        {
            var sb = new StringBuilder();
            Print(node, sb);
            return sb.ToString();
        }
    }
}

