using LanguageInterpreterLibrary.TokenInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageInterpreterLibrary.Types
{
    public class TypeList
    {
        public static List<TokenId> Types { get; }
        static TypeList()
        {
            Types = new List<TokenId>()
                {
                    new TokenId("EmptyOperator", @"[\ \n\r]"),
                    new TokenId("Variable", @"[a-z]{1,}[_]{0,}[a-z]{0,}"),
                    new TokenId("Integer", @"[0-9]{1,7}"),
                    new TokenId("EndLine", @";"),
                    new TokenId("AssignmentOperator", @"\:{2}\="),// ::=
                    new TokenId("Terminal", "Print"),
                    new TokenId("Addition", @"\+"),
                    new TokenId("Subtraction", @"\-"),
                    new TokenId("Multiplication", "\\*"),
                    new TokenId("Division", @"\/"),
                    new TokenId("LeftBracket", @"\["),
                    new TokenId("RightBracket", @"\]"),
                    new TokenId("Comment", "//[а-я_]{0,}"),
                };
        }
        public static TokenId GetTokenBy(string identifier)
        {
            return Types.FirstOrDefault(id => id.Identifier == identifier);
        }
    }

}
