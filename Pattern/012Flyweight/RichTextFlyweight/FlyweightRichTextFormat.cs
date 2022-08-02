using System;
using static System.Console;
using System.Collections.Generic;

namespace RichTextFlyweight
{
    class FlyweightRichTextFormat
    {
        public string Memory => String.Format(Parrern.Format, memory, fr.Count * (sizeof(int) + sizeof(int) + sizeof(ConsoleColor)));

        private int memory;
        private readonly string text;
        private readonly List<FormattedRange> fr;

        private ConsoleColor GetColor(int position)
        {
            foreach (var item in fr)
                if (item.Check(position)) { memory++; return item.color; }

            return ConsoleColor.White;
        }

        public FlyweightRichTextFormat(string text)
        {
            this.text = text;
            fr = new List<FormattedRange>();
        }

        public void ColorRande(int start, int length, ConsoleColor console)
            => fr.Add(new FormattedRange(start, length, console));

        public void Print()
        {
            int len = text.Length;

            for (int i = 0; i < len; i++)
            {
                ForegroundColor = GetColor(i);
                Write(text[i]);
            }
            ForegroundColor = ConsoleColor.White;
        }
    }
}