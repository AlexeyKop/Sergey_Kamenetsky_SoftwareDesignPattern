namespace TextMemento
{
    public class Memento
    {
        public string Text { get; init; }
        public Memento(string text) => this.Text = text;
    }
}
