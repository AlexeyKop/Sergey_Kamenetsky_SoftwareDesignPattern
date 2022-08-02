namespace ArithmeticExpressionVisitor1
{
    class Numbers : Node
    {
        public int Value { get; set; }
        public override string ToString() => $"{Value}";
    }
}

