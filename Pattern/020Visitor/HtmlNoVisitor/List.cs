using System.Text;

namespace HtmlNoVisitor
{
    class List : Element
    {
        public ListItem[] Items { get; set; }
        public List(params ListItem[] args) => Items = args;
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("<ul>\n");
            foreach (var item in Items)
            {
                //Console.WriteLine($"{item.GetType()}");
                sb.Append(item.ToString());
            }
            sb.Append("</ul>\n");
            return sb.ToString();
        }
    }
}
