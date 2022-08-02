using System.Text;

namespace HtmlVisitor
{
    class MarkdownVisitor : IVisitor
    {
        StringBuilder result = new StringBuilder();
        public string Result => result.ToString();
        public void VisitText(Text t) => result.Append($"**{t.Value}**\n");
        public void VisitParagraph(Paragraph p) => result.Append($"#{p.Value}\n===========\n");
        public void VisitListItem(ListItem li) => result.Append($"*{li.Item}\n");
        public void VisitList(List lu)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var e in lu.Items) sb.Append($"*{e.Item}\n"); 
            result.Append(sb.ToString());
        }
    }
}