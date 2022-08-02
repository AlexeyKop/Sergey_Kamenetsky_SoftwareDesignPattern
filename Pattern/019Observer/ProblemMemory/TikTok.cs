using System;
using static System.Console;

namespace ProblemMemoryFramework472
{
    class TikTok : IDisposable
    {
        private Logger logger;
        public TikTok(Logger logger)
        {
            this.logger = logger;
            this.logger.OnLog += Logger_OnLog;
        }
        private void Logger_OnLog(object sender, EventArgs e) => WriteLine("Запись в лог а");

        public void Dispose()
        {
            this.logger = null;
        }

        ~TikTok() => WriteLine("~TikTokUser");
    }
}