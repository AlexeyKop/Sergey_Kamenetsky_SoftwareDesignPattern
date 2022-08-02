namespace ArithmeticExpressionVisitor1
{
    class ArithmeticExpression : Node
    {
         
        public string Operation { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public override string ToString() => $"({Left}{Operation}{Right})";
    }
}

