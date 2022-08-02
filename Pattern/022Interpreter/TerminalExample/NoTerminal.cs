namespace TerminalExample
{
    public class NoTerminal
    {
        public static void Interpret(Context c)
        {
            if (c.Position >= c.Chain.Length) return;
            Terminal.Interpret(c);
            c.Position++;
            if (c.Result) Interpret(c);
        }
    }
}