namespace HtmlVisitor
{
    interface IVisitor
    {
        string Result { get; }
        void VisitText(Text t);
        void VisitParagraph(Paragraph p);
        void VisitListItem(ListItem li) ;
        void VisitList(List lu);
    }
}