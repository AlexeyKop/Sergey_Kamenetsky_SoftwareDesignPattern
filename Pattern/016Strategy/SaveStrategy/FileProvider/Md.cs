using SaveStrategy.interfaces;
using System.Text;

namespace SaveStrategy.FileProvider
{
    class Md : IFormatStrategy
    {
        public static Md Provider = new Md();
        public void AddElement(StringBuilder sb, string title, string value)
        {
            sb.Append($"**{title}** *{value}*\n");
        }

        public void Close(StringBuilder sb) { }

        public void Init(StringBuilder sb) { }
    }
}
