using System;
using static System.Console;
using System.Linq;

namespace RichTextFlyweight
{
    class RichTextFormat
    {
        public string Memory => String.Format(Parrern.Format, colors.Length, colors.Length * sizeof(ConsoleColor));

        private readonly string text;
        private readonly ConsoleColor[] colors;

        public RichTextFormat(string text)
        {
            this.text = text;
            colors = text.Select(c => ConsoleColor.White).ToArray();
        }

        public void ChangeColor(int start, int length, ConsoleColor color)
        {
            int end = start + length;
            for (int i = start; i < end; i++) colors[i] = color;
        }

        public void Print()
        {
            int len = text.Length;
            for (int i = 0; i < len; i++)
            {
                ForegroundColor = colors[i];
                Write(text[i]);
            }
            ForegroundColor = ConsoleColor.White;
        }

    }
}