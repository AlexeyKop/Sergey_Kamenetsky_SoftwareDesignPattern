namespace HtmlVisitor
{
    class ListItem : Element
    {
        public string Item { get; set; }
        public ListItem(string args) => Item = args;

        public override void Accept(IVisitor visitor) => visitor.VisitListItem(this);
    }
}