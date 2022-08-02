using System;

namespace RichTextFlyweight
{
    class FormattedRange
    {
        public int start, length;

        public ConsoleColor color;

        public bool Check(int pos) => pos >= start && pos <= (start + length - 1);

        public FormattedRange(
            int start = 0,
            int length = 0,
            ConsoleColor color = ConsoleColor.White
            )
        {
            this.start = start;
            this.length = length;
            this.color = color;
        }

    }
}