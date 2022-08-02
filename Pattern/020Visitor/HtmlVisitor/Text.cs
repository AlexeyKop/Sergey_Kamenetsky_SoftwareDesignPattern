namespace HtmlVisitor
{
    class Text : Element
    {
        public string Value { get; set; }
        public Text(string text) => this.Value = text;
        public override void Accept(IVisitor visitor) => visitor.VisitText(this);
    }
}