using ApiFacade.Demo;
using ApiFacade.Infrastructure;
using ApiFacade.Json;
using ApiFacade.TelegramBase;
using ApiFacade.TelegramLib;
using System;
using System.Text;

namespace ApiFacade
{
    class Program
    {
        static void Main(string[] args)
        {

            TelegramNotApi.GetUpdates(TelegramData.Token);

            TelegramClient bot = new TelegramClient(TelegramData.Token);


            Console.WriteLine(bot.GetMe().result.username);

            bot.OnMessage += (arg) =>
            {
                Console.WriteLine($"{arg.FirstName}: {arg.Text}");

                bot.SendMessage(
                    chatId: arg.ChatId,
                    text: "Получено",
                    replyToMsgId: arg.MessageId
                    );
            };

            bot.Start();


        }

      
    }
}
