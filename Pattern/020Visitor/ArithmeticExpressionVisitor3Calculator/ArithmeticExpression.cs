namespace ArithmeticExpressionVisitor3Calculator
{
    class ArithmeticExpression : Node
    {
        public string Operation { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
    }
}