using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageInterpreterLibrary.TokenInfo
{
    public class Token
    {
        public TokenId Id { get; init; }
        public string Value { get; init; }
        public int Position { get; init; }
        public Token(TokenId type, string value, int position)
        {
            this.Id = type;
            this.Value = value;
            this.Position = position;
        }
        public override string ToString()
            => $"TOKEN [ Value: {Value}] Position: {Position}\n   Id: {Id} ";
    }
}
