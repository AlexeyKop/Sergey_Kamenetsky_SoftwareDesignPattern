using System;

namespace HtmlNoVisitor
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

            string html = String.Empty;
            foreach (var item in doc)
            {
                //Console.WriteLine($"{item.GetType()}");
                html += $"{item}";
            }

            Console.WriteLine(html);

           
        }
    }
}
