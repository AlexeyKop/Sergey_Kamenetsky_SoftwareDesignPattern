using LanguageInterpreterLibrary.TokenInfo;

namespace LanguageInterpreterLibrary.Symbols
{
    public class Unary : ArithmeticOperation
    {
        public Token Operator { get; set; }
        public Symbol Operand { get; set; }
        public Unary(Token op, Symbol operand)
        {
            this.Operator = op;
            this.Operand = operand;
        }
    }
}
