using System.Collections.Generic;

namespace LanguageInterpreterLibrary.Symbols
{
    public class AvailableSymbol : Symbol
    {
        public List<Symbol> CodeLine { get; set; }
        public AvailableSymbol() => this.CodeLine = new();
        public void Add(Symbol node) => this.CodeLine.Add(node);
    }
}
