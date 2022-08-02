using System;

namespace HtmlVisitor
{

    class Program
    {
        static void Main(string[] args)
        {
            var par = new Paragraph("текст");
            var one = new ListItem("one");
            var two = new ListItem("two");
            var three = new ListItem("three");
            var ul = new List(one, two, three);

            var doc = new Element[] { par, ul };

            IVisitor visitor = new HtmlVisitor();
            foreach (var item in doc) item.Accept(visitor);

            Console.WriteLine(visitor.Result);

            visitor = new MarkdownVisitor();
            foreach (var item in doc) item.Accept(visitor);

            Console.WriteLine(visitor.Result);
        }
    }
}