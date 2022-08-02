using StaticStrategy.Interfaces;
using System.Text;

namespace StaticStrategy.FileProvider
{
    class Json : IFormatStrategy
    {
        public static Json Provider = new();

        public void AddElement(StringBuilder sb, string title, string value)
        {
            sb.Append($"  '{title}': '{value}',\n");
        }

        public void Close(StringBuilder sb)
        {
            sb.Append('}');
        }

        public void Init(StringBuilder sb)
        {
            sb.Append("{\n");
        }
    }
}
