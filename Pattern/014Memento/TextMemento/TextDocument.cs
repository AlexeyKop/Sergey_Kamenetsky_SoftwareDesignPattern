namespace TextMemento
{
    public class TextDocument
    {
        private string Text { get; set; }

        public Memento Change(string s)
        {
            Text += $"{s}\n";
            return new Memento(Text);
        }
 
        public void RestoreState(Memento state)
        {
            this.Text = state.Text;
        }

        public override string ToString() => this.Text;
    }
}
