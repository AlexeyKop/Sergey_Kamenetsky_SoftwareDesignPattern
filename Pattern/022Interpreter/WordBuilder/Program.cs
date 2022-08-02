using System;
using static System.Console;

namespace WordBuilder
{
    class Program
    {
        private static int count;
        private static void Find(char[] alphabet, char[] chain, int position = 0)
        {
            if (position == chain.Length)
            {
                count++;
                //WriteLine($"{count} {String.Join('\0', chain)}");
                return;
            }
            char[] temp = chain;
            for (int i = 0; i < alphabet.Length; i++)
            {
                temp[position] = alphabet[i];
                Find(alphabet, temp, position + 1);
            }
        }

        private static void CurrentDic(string alphabet, int len)
        {
            var alp = alphabet.ToCharArray();
            Find(alp, new char[len]);
            WriteLine($"len = {len}  alphabet = {alphabet}  count = {count}\n");
            count = 0;
        }

        static void Main()
        {
            // Бесконечно, но счётно
            const int n = 10;
            for (int i = 0; i <= n; i++) { CurrentDic("abc", i); }

        }
    }
}
