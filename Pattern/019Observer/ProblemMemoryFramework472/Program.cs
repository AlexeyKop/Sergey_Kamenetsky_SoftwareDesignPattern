using System;
using static System.Console;

namespace ProblemMemoryFramework472
{
    class Program
    {
        static void Main(string[] args)
        {
            // #OldSchool
            var log = new Logger();
            var tt = new TikTok(log);
            WeakReference wrtt = new WeakReference(tt);
            Console.WriteLine($"wrtt.IsAlive: {wrtt.IsAlive}");
            log.Log();
            

            tt.Dispose();
            tt = null;
            WriteLine("tt = null;");
            Console.WriteLine($"wrtt.IsAlive: {wrtt.IsAlive}");

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            Console.WriteLine($"wrtt.IsAlive: {wrtt.IsAlive}");

            
            log = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            WriteLine("log = null");
            Console.WriteLine($"wrtt.IsAlive: {wrtt.IsAlive}");


            //log.Log();

        }
    }
}