using SaveStrategy.interfaces;
using System.Text;

namespace SaveStrategy.FileProvider
{
    class Xml : IFormatStrategy
    {
        public static Xml Provider = new();
        public void AddElement(StringBuilder sb, string title, string value)
        {
            sb.Append($"  <{title}>{value}</{title}>\n");
        }

        public void Close(StringBuilder sb)
        {
            sb.Append("</xml>");
        }

        public void Init(StringBuilder sb)
        {
            sb.Append("<xml ver='0.001'>\n");
        }
    }
}
