using System;

namespace TerminalExample
{
    public class Terminal
    {
        public static void Interpret(Context c)
        {
            var alp = c.Alphabet;
            var str = c.Chain;
            foreach (var item in alp)
            {
                while (str.IndexOf(item)!=-1) 
                { str = str.Replace(item, String.Empty); }
            }
            c.Result = str == String.Empty;
        }
    }
}