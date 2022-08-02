using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleMemento
{
    partial class TextDocument
    {
        private readonly StringBuilder text;
        private int pages;

        public TextDocument() => text = new();

        public string Text => this.text.ToString();
        public int Pages => pages;

        public void Change(string s = "")
        {
            if (String.IsNullOrEmpty(s))
                s = Guid.NewGuid().ToString();
            text.Append($"{s}\n");
        }

        public void SaveTo(IList<Memento> col)
        {
            col.Add(new Memento(this.text.ToString(), this.pages));
        }

        public void RestoreState(Memento state)
        {
            this.pages = state.PagesState;
            this.text.Clear();
            this.text.Append(state.TextState);
        }
        public override string ToString() => Text.ToString();
    }
}
