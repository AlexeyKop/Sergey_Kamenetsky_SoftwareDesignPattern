using LanguageInterpreterLibrary.Exceptions;
using LanguageInterpreterLibrary.TokenInfo;
using LanguageInterpreterLibrary.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LanguageInterpreterLibrary.Analyzers
{
    public class Tokenizer
    {
        private readonly string sourceCode;
        private int cursorPosition;
        public List<Token> Tokens { get; set; }
        public Tokenizer(string code)
        {
            cursorPosition = 0;
            sourceCode = code;
            Tokens = new List<Token>();

            #region filteringCommentents

            this.sourceCode = String.Join('\n',
                code.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(e =>
                    {
                        var pos = e.IndexOf("//");
                        return pos == -1 ? e : e.Substring(0, pos);
                    }));

            #endregion
        }
        public List<Token> Analysis()
        {
            while (GetToken()) {; }
            return Tokens =
            Tokens
            .Where(t => t.Id.Identifier != TypeList.GetTokenBy("Comment").Identifier)
            .Where(t => t.Id.Identifier != TypeList.GetTokenBy("EmptyOperator").Identifier)
            .ToList();
        }
        public bool GetToken()
        {
            if (cursorPosition >= sourceCode.Length) return false;
            foreach (TokenId tokenType in TypeList.Types)
            {
                Regex regex = new($"^{tokenType.SearchPattern}");
                string result = regex.Match(sourceCode[cursorPosition..]).Value;
                if (!string.IsNullOrEmpty(result))
                {
                    Token token = new(tokenType, result, cursorPosition);
                    cursorPosition += result.Length;
                    Tokens.Add(token);
                    return true;
                }
            }
            throw new GetTokenException() { ErrorPosition = cursorPosition };
        }
    }
}
