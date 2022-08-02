using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ApiFacade.Infrastructure
{
    public sealed class TelegramData
    {
        public static string Token { get; set; }
        static TelegramData()
        {
            //Token = File.ReadAllText(@"c:\token");
            // или
            // Token = "1234567:4TT8bAc8GHUspu3ERYn-KGcvsvGB9u_n4ddy"
        }

    }
}
