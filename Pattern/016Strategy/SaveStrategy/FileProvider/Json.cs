using SaveStrategy.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveStrategy.FileProvider
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
