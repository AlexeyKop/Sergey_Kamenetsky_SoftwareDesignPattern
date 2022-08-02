using SaveStrategy.FileProvider;
using SaveStrategy.interfaces;
using System.Collections.Generic;
using System.Text;

namespace SaveStrategy
{
    class Document
    {
        readonly StringBuilder sb;
        readonly IFormatStrategy formatStrategy;
        public Document(DocumentFormat df)
        {
            sb = new StringBuilder();
            formatStrategy = df switch
            {
                DocumentFormat.Json => new Json(),
                DocumentFormat.Xml => new Xml(),
                _ => new Md()
            };
            formatStrategy.Init(sb);

        }

        public Document Append(string title, string value)
        {
            formatStrategy.AddElement(sb, title, value);
            return this;
        }

        public string Save()
        {
            formatStrategy.Close(sb);
            return sb.ToString();
        }

        public static string Convert(Dictionary<string,string> dic, IFormatStrategy format)
        {
            StringBuilder t = new();
            format.Init(t);

            foreach (var item in dic)
            {
                format.AddElement(t, item.Key, item.Value);
            }

            format.Close(t);
            return t.ToString();
        }


    }
}
