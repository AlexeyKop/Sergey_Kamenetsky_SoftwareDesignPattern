namespace HtmlVisitor
{
    class List : Element
    {
        public ListItem[] Items { get; set; }
        public List(params ListItem[] args) => Items = args;
        public override void Accept(IVisitor visitor) => visitor.VisitList(this);
    }
}