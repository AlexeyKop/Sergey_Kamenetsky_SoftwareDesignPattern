using LanguageInterpreterLibrary.TokenInfo;

namespace LanguageInterpreterLibrary.Symbols
{
    public class Integer : Symbol
    {
        public Token Number { get; set; }
        public Integer(Token number) => this.Number = number;
    }
}
