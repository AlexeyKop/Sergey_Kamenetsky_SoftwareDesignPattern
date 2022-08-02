namespace ArithmeticExpressionVisitor3Calculator
{
    class Calculator
    {
        int result;
        Node exp;
        public Calculator(Node expression)
        {
            exp = expression;
            result = 0;          
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

        public override string ToString()
        {
            result = 0;
            Calc(exp, ref result);
            return result.ToString();
        }
    }
}