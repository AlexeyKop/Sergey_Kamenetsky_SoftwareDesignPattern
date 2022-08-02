using System;
using static System.Console;
using LanguageInterpreterLibrary.Analyzers;

namespace LanguageInterpreterLibrary
{
    class Demo
    {
        static void Main()
        {
            // Для запуска измените тип проекта
            var sourceCode =
            @"
                like ::= 1; 
                subscribe ::= like;
                Print [like + subscribe]*[2];

            ";

            Tokenizer lexer = new(sourceCode);
            lexer.Analysis();
            foreach (var item in lexer.Tokens) WriteLine(item);
             
            var pp = new Parser(lexer.Tokens);
            foreach (var item in pp.res) WriteLine($"{item}");
        }
    }
}