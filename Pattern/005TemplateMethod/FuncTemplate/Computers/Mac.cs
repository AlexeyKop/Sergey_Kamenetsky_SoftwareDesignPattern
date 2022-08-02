using System;
using System.Threading;
using static System.Console;

namespace FuncTemplate.Computers
{
    class Mac
    {
        private bool power;
        public void PowerOn() => WriteLine("Apple Computer Power On");
        public void PowerOff() => WriteLine("Apple Computer Power Off");

        public Mac() => power = true;
        public bool Power() => power;

        public void Rendering()
        {
            var time = DateTime.Now;
            WriteLine("Start rendering...");
            while ((DateTime.Now - time).TotalSeconds < 3)
            {
                Thread.Sleep(500);
                WriteLine("Rendering...");
            }
            WriteLine("Task accomplished!");
            power = false;
        }
    }
}
