using ApiFacade.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Xml.Serialization;

namespace ApiFacade.TelegramBase
{
    public class TelegramNotApi
    {
        static public void GetUpdates(string token)
        {
           
            string url = $"https://api.telegram.org/bot{token}/getMe";

            HttpClient hc = new HttpClient();
            var json = hc.GetStringAsync(url).Result;
            Console.WriteLine($"{json}");

            //{
            //  "ok": true,
            //  "result": {
            //    "id": 1003004005,
            //    "is_bot": true,
            //    "first_name": "Friendly Bot",
            //    "username": "iFriendlyBot",
            //    "can_join_groups": true,
            //    "can_read_all_group_messages": false,
            //    "supports_inline_queries": false
            //  }
            //}

            


            Console.WriteLine();

            while (true)
            {
                url = $"https://api.telegram.org/bot{token}/getUpdates";
                json = hc.GetStringAsync(url).Result;
                Console.WriteLine($"{json}\n\n");

                Thread.Sleep(1000);


            }
        }
    }
}
