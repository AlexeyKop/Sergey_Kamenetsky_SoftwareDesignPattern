using System.Text;

namespace HtmlVisitor
{
    class HtmlVisitor : IVisitor
    {
        StringBuilder result = new StringBuilder();
        public string Result => result.ToString();
        public void VisitText(Text t) => result.Append($"{t.Value}\n");
        public void VisitParagraph(Paragraph p) => result.Append($"<p>\n{p.Value}\n</p>\n");
        public void VisitListItem(ListItem li) => result.Append($"<li>{li.Item}</li>\n");
        public void VisitList(List lu)
        {
            StringBuilder sb = new StringBuilder("<ul>\n");
            foreach (var e in lu.Items)
            {
                sb.Append($"<li>{e.Item}</li>\n");
            }
            sb.Append("</ul>\n");
            result.Append(sb.ToString());
        }
    }
}