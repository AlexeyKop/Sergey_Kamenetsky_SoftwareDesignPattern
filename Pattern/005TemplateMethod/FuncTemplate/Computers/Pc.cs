using static System.Console;
using System;
using System.Threading;

class Pc
{
    private bool power;
    public void PowerOn() => WriteLine("Start bios...\bstart os...");

    public Pc() => power = true;
    public bool Power() => power;

    public void PlayDota()
    {
        WriteLine("GG WP...");
        Random r = new Random();

        while (true)
        {
            string act = " click. ";

            Thread.Sleep(100);
            SetCursorPosition(
                r.Next(WindowWidth - act.Length),
                r.Next(WindowHeight));
            Write(act);
        }
    }
}