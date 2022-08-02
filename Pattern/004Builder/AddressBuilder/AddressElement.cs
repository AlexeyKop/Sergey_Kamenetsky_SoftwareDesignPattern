using System;
using System.Collections.Generic;

namespace AddressBuilder
{
    class AddressElement
    {
        public string Title { get; set; }
        public string Value { get; set; }
        private List<AddressElement> Elements { get; set; }

        public void AddElement(string title, string value)
            => Elements.Add(new AddressElement(title, value));

        public AddressElement(string title, string value)
        {
            this.Title = title;
            this.Value = value;
            Elements = new List<AddressElement>();
        }

        private string Print(string indent = "")
        {
            string result = String.Empty;

            indent += " ";
            result += $"{indent}#{Title}: {Value}\n";

            foreach (var item in Elements)
            {
                result += item.Print(indent);
            }

            return result;
        }
        public override string ToString() => Print();
    }
}
