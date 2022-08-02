namespace ArithmeticExpressionVisitor3Calculator
{
    class Numbers : Node
    {
        public int Value { get; set; }
        
        #region ToDo

        public static implicit operator Numbers(int v) => new() { Value = v };
        public static ArithmeticExpression operator +(Numbers x, Numbers y) => new() { Left = x, Operation = "+", Right = y };
        public static ArithmeticExpression operator -(Numbers x, Numbers y) => new() { Left = x, Operation = "-", Right = y };
        public static ArithmeticExpression operator *(Numbers x, Numbers y) => new() { Left = x, Operation = "*", Right = y };
        public static ArithmeticExpression operator /(Numbers x, Numbers y) => new() { Left = x, Operation = "/", Right = y };
        
        #endregion
    }
}

