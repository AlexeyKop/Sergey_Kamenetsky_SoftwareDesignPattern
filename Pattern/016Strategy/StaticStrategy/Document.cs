using StaticStrategy.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace StaticStrategy
{
    class Document<T>
        where T: IFormatStrategy, new()
    {
        readonly StringBuilder sb;
        readonly T formatStrategy;
        public Document()
        {
            sb = new StringBuilder();
            formatStrategy = new T();
            formatStrategy.Init(sb);

        }

        public Document<T> Append(string title, string value)
        {
            formatStrategy.AddElement(sb, title, value);
            return this;
        }
        public Document<T> AppendAll(Dictionary<string, string> dic)
        {
            foreach (var item in dic)
            {
                formatStrategy.AddElement(sb, item.Key, item.Value);
            }
            return this;
        }


        public string Save()
        {
            formatStrategy.Close(sb);
            return sb.ToString();
        }
    }
}
