using LanguageInterpreterLibrary.TokenInfo;

namespace LanguageInterpreterLibrary.Symbols
{
    public class Variable : Symbol
    {
        public Token Field { get; set; }
        public Variable(Token field) => this.Field = field;
    }
}
