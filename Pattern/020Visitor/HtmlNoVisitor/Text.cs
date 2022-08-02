namespace HtmlNoVisitor
{
    class Text : Element
    {
        public string Value { get; set; }
        public Text(string text) => this.Value = text;
        public override string ToString() => $"{Value}\n";
    }
}
