namespace SimpleMemento
{
    partial class TextDocument
    {
        public class Memento
        {
            readonly string textState;
            readonly int pagesState;

            public Memento(string text, int pages)
            {
                textState = text;
                pagesState = pages;
            }

            public string TextState
            {
                get => this.textState;
                //set => this.textState = value;
            }

            public int PagesState
            {
                get => this.pagesState;
                //set => this.pagesState = value;
            }
        }
    }
}
