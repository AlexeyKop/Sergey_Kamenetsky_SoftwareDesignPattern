namespace LanguageInterpreterLibrary.TokenInfo
{
    public class TokenId
    {
        public string Identifier { get; init; }
        public string SearchPattern { get; init; }
        public TokenId(string id, string pattern)
        {
            Identifier = id;
            SearchPattern = pattern;
        }
        public override string ToString() => $"TokenType [ Identifier: {Identifier}]";
    }
}
