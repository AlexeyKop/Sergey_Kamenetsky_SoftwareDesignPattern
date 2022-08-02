using StaticStrategy.Interfaces;
using System.Text;

namespace StaticStrategy.FileProvider
{
    class Md : IFormatStrategy
    {
        public static Md Provider = new();
        public void AddElement(StringBuilder sb, string title, string value)
        {
            sb.Append($"**{title}** *{value}*\n");
        }

        public void Close(StringBuilder sb) { }

        public void Init(StringBuilder sb) { }
    }
}
