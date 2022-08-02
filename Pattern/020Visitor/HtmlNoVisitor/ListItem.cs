namespace HtmlNoVisitor
{
    class ListItem : Element
    {
        public string Item { get; set; }
        public ListItem(string args) => Item = args;
        public override string ToString() => $"<li>{Item}</li>\n";
    }
}
