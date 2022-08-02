 
using ApiFacade.TelegramLib.Models;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
 
namespace ApiFacade.TelegramLib
{
    class TelegramClient
    {
        string token;
        HttpClient hc;
        Thread t;
        string baseUri;
        public TelegramClient(string token)
        {
            this.token = token;
            hc = new HttpClient();
            baseUri = $"https://api.telegram.org/bot{token}/";
        }

        /// <summary>
        /// Подробнее <para>https://core.telegram.org/bots/api#getme</para>
        /// </summary>
        /// <returns></returns>
        public GetMeModel GetMe()
        {
            var json = hc.GetStringAsync($"{baseUri}getMe").Result;

            return JsonSerializer.Deserialize<GetMeModel>(json);
        }

        /// <summary>
        /// Подробности <para>https://core.telegram.org/bots/api#sendmessage</para>
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="text"></param>
        /// <param name="replyToMsgId"></param>
        /// <returns></returns>
        public string SendMessage(long chatId, string text, object replyToMsgId)
        {
            string url = String
                .Format("{0}sendMessage?chat_id={1}&text={2}&reply_to_message_id={3}",
                baseUri,
                chatId,
                text,
                replyToMsgId);


            return hc.GetStringAsync(url).Result;
        }

        public event Action<TelegramMessageModel> OnMessage;

        public void Start()
        {
            t = new Thread(new ThreadStart(GetMessage));
            t.Start();
        }

        /// <summary>
        /// Подробнее 
        /// <para>https://core.telegram.org/bots/api#getting-updates </para>
        /// <para>https://core.telegram.org/bots/api#getupdates</para>
        /// </summary>
        private void GetMessage()
        {
            if (OnMessage == null) return;
            long update_id = 0;
            while (true)
            {
                string url = $"{baseUri}getUpdates?offset={update_id + 1}";
                dynamic response = 
                    Newtonsoft
                    .Json
                    .Linq
                    .JObject
                    .Parse(hc.GetStringAsync(url).Result);

                //Console.WriteLine($"{response.result}\n\n");



                foreach (var message in response.result)
                {
                    update_id = message.update_id;
                    var msg = new TelegramMessageModel()
                    {
                        Text = message.message.text,
                        ChatId = message.message.chat.id,
                        FirstName = message.message.chat.first_name,
                        MessageId = message.message.message_id
                    };

                    OnMessage(msg);
                }
                Thread.Sleep(100);
            }
        }


    }
}
