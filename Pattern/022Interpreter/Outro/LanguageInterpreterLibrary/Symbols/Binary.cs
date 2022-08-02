using LanguageInterpreterLibrary.TokenInfo;

namespace LanguageInterpreterLibrary.Symbols
{
    public class Binary : ArithmeticOperation
    {
        public Token Operator { get; set; }
        public Symbol Left { get; set; }
        public Symbol Right { get; set; }
        public Binary(Symbol left, Token op, Symbol right)
        {
            this.Operator = op;
            this.Left = left;
            this.Right = right;
        }
    }
}
