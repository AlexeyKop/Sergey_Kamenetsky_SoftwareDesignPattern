using System;

namespace ProblemMemoryFramework472
{
    class Logger
    {
        public event EventHandler OnLog;
        public void Log() => OnLog?.Invoke(this, new EventArgs());
    }
}