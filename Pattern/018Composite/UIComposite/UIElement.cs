using System.Collections.Generic;

namespace UIComposite
{
    class UIElement
    {
        public List<UIElement> Children { get; set; }
        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public UIElement(string name)
        {
            Name = name;
            Width = 150;
            Height = 50;
            Children = new();
        }
        protected virtual string Draw(string p = "")
        {
            string s = $"{p}{Name}\n";
            foreach (var item in Children) s += item.Draw($"  {p}");
            return s;
        }
        public override string ToString() => $"{Draw()}";
    }
}