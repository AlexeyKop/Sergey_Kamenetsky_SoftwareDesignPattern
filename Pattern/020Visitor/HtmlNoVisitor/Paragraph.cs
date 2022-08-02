namespace HtmlNoVisitor
{
    class Paragraph : Element
    {
        public string Value { get; set; }
        public Paragraph(string text) => this.Value = text;
        public override string ToString() => $"<p>\n{Value}\n</p>\n";
    }
}
