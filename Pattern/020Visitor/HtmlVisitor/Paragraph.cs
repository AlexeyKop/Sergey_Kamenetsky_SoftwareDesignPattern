namespace HtmlVisitor
{
    class Paragraph : Element
    {
        public string Value { get; set; }
        public Paragraph(string text) => this.Value = text;
        public override void Accept(IVisitor visitor) => visitor.VisitParagraph(this);
    }
}