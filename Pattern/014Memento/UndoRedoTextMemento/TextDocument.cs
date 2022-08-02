using System.Collections.Generic;

namespace TextMemento
{
    public class TextDocument
    {
        private int index;
        private readonly List<Memento> mementos;
        private string Text { get; set; }

        public TextDocument(string text)
        {
            index = 0;
            mementos = new();
            
            Text = $"{text}"; ;
            mementos.Add(new Memento(Text));
        }


        public Memento Change(string s)
        {
            Text += $"{s}";
            var state = new Memento(Text);
            mementos.Add(state);
            ++index;
            return state;
        }

        public void RestoreState(Memento state)
        {
            if (state == null) return;

            Text = state.Text;
            mementos.Add(state);
            index = mementos.Count - 1;

            this.Text = state.Text;
        }

        public override string ToString() => this.Text;

        public Memento Undo()
        {
            if (index <= 0) return null;
            var state = mementos[--index];
            Text = state.Text;
            return state;
        }

        public Memento Redo()
        {
            if (index + 1 >= mementos.Count) return null;
            var state = mementos[++index];
            Text = state.Text;
            return state;
        }

    }
}
