namespace ArithmeticExpressionVisitor3Calculator
{
    class ArithmeticExpression : Node
    {
        public string Operation { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        #region ToDo

        public static ArithmeticExpression operator +(ArithmeticExpression x, Numbers y) => new() { Left = x, Operation = "+", Right = y };
        public static ArithmeticExpression operator -(ArithmeticExpression x, Numbers y) => new() { Left = x, Operation = "-", Right = y };
        public static ArithmeticExpression operator *(ArithmeticExpression x, Numbers y) => new() { Left = x, Operation = "*", Right = y };
        public static ArithmeticExpression operator /(ArithmeticExpression x, Numbers y) => new() { Left = x, Operation = "/", Right = y };

        public static ArithmeticExpression operator +(ArithmeticExpression x, ArithmeticExpression y) => new() { Left = x, Operation = "+", Right = y };
        public static ArithmeticExpression operator -(ArithmeticExpression x, ArithmeticExpression y) => new() { Left = x, Operation = "-", Right = y };
        public static ArithmeticExpression operator *(ArithmeticExpression x, ArithmeticExpression y) => new() { Left = x, Operation = "*", Right = y };
        public static ArithmeticExpression operator /(ArithmeticExpression x, ArithmeticExpression y) => new() { Left = x, Operation = "/", Right = y };

        #endregion

    }
}

