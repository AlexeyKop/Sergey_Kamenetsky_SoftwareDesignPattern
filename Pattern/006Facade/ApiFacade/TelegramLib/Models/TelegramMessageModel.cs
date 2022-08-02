using System;
using System.Collections.Generic;
using System.Text;

namespace ApiFacade.TelegramLib.Models
{
    public class TelegramMessageModel
    {
        public string Text { get; set; }
        public string FirstName { get; set; }
        public long ChatId { get; set; }
        public object MessageId { get; internal set; }
    }
}
