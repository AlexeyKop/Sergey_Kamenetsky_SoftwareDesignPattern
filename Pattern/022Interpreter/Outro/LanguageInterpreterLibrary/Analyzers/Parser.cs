using LanguageInterpreterLibrary.Exceptions;
using LanguageInterpreterLibrary.Symbols;
using LanguageInterpreterLibrary.TokenInfo;
using LanguageInterpreterLibrary.Types;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace LanguageInterpreterLibrary.Analyzers
{
    using static System.Convert;
    public class Parser
    {
        private Symbol expressionNode;
        private List<Token> Tokens { get; init; }
        private int position;
        public Dictionary<string, string> fields = new();
        public ObservableCollection<string> res = new();

        public Parser(List<Token> tokens)
        {
            Tokens = tokens;
            position = 0;
            expressionNode = Parse();
            res.Clear();
            Start(expressionNode);
        }
        public Token Check(List<TokenId> token)
        {
            if (position < Tokens.Count)
            {
                Token t = Tokens[position];
                TokenId exp = token.FirstOrDefault(e => e.Identifier == t.Id.Identifier);
                if (exp != null)
                {
                    position++;
                    return t;
                }
            }
            return null;
        }
        public Token Take(List<TokenId> token)
        {
            var t = Check(token);
            return t ?? throw new TakeTokenException()
            {
                ErrorPosition = t?.Position ?? default,
                Text = token.FirstOrDefault()?.Identifier ?? default
            };
        }

        public Symbol TerminalProcessing()
        {
            Token t = this.Check(new() { TypeList.GetTokenBy("Terminal") });
            if (t != null) return new Unary(t, this.ArithmeticExpressionProcessing());
            throw new TerminalProcessingException
            {
                ErrorPosition = t.Position,
                Text = "Terminal Expected"
            };
        }
        public Symbol VariableOrIntegerProcessing()
        {
            Token t = this.Check(new() { TypeList.GetTokenBy("Integer") });
            if (t != null) return new Integer(t);
            t = this.Check(new() { TypeList.GetTokenBy("Variable") });
            if (t != null) return new Variable(t);
            throw new VariableOrIntegerProcessingException()
            {
                ErrorPosition = t.Position,
                Text = "Variable Expected"
            };
        }
        public Symbol BracketsProcessing()
        {
            if (Check(new() { TypeList.GetTokenBy("LeftBracket") }) != null)
            {
                Symbol n = ArithmeticExpressionProcessing();
                Take(new() { TypeList.GetTokenBy("RightBracket") });
                return n;
            }
            else { return VariableOrIntegerProcessing(); }
        }
        public Symbol ArithmeticExpressionProcessing()
        {
            Symbol left = BracketsProcessing();
            Token op = Check(new()
            {
                TypeList.GetTokenBy("Subtraction"),
                TypeList.GetTokenBy("Addition"),
                TypeList.GetTokenBy("Multiplication"),
                TypeList.GetTokenBy("Division")
            }
            );

            while (op != null)
            {
                Symbol right = BracketsProcessing();
                left = new Binary(left, op, right);
                op = Check(new()
                {
                    TypeList.GetTokenBy("Subtraction"),
                    TypeList.GetTokenBy("Addition"),
                    TypeList.GetTokenBy("Multiplication"),
                    TypeList.GetTokenBy("Division")
                });
            }
            return left;
        }
        public Symbol ExpressionProcessing()
        {
            if (Check(new() { TypeList.GetTokenBy("Variable") }) == null)
                return TerminalProcessing();
            position--;
            Symbol n = VariableOrIntegerProcessing();
            Token t = Check(new() { TypeList.GetTokenBy("AssignmentOperator") });
            if (t != null)
            {
                Symbol right = ArithmeticExpressionProcessing();
                Binary binary = new Binary(n, t, right);
                return binary;
            }
            throw new ExpressionProcessingException()
            {
                ErrorPosition = t.Position,
                Text = "Assignment Expected"
            };
        }

        public Symbol Parse()
        {
            AvailableSymbol an = new();

            while (this.position < this.Tokens.Count)
            {
                Symbol n = ExpressionProcessing();
                Take(new() { TypeList.GetTokenBy("EndLine") });
                an.Add(n);
            }
            return an;
        }

        public int? Start(Symbol symbol)
        {
            if (symbol is Integer i) { return int.Parse(i.Number.Value); }
            if (symbol is Unary u)
            {
                switch (u.Operator.Id.Identifier)
                {
                    case "Terminal":
                        res.Add($">  {this.Start(u.Operand)}");
                        return Start(u.Operand);
                }
            }
            if (symbol is Binary b)
            {
                switch (b.Operator.Id.Identifier)
                {
                    case "Addition": return ToInt32(Start(b.Left)) + ToInt32(Start(b.Right));
                    case "Subtraction": return ToInt32(Start(b.Left)) - ToInt32(Start(b.Right));
                    case "Multiplication": return ToInt32(Start(b.Left)) * ToInt32(Start(b.Right));
                    case "Division": return ToInt32(Start(b.Left)) / ToInt32(Start(b.Right));

                    case "AssignmentOperator":
                        int? result = Start(b.Right);
                        Variable variableNode = (Variable)b.Left;
                        fields[variableNode.Field.Value] = result.ToString();
                        return result;
                }
            }
            if (symbol is Variable v)
            {
                if (!fields.ContainsKey(v.Field.Value)) throw new VariableNotFoundException()
                {
                    ErrorPosition = v.Field.Position,
                    Text = v.Field.Value
                };

                return ToInt32(fields[v.Field.Value]);
            }
            if (symbol is AvailableSymbol a)
            {
                a.CodeLine.ForEach(codeString => Start(codeString));
                return null;
            }
            throw new InterpreterException() { Text = "Mistake" };
        }
    }
}
