using System;

namespace ApiFacade.TelegramLib.Models
{
    public class ResultModel
    {
        public ResultModel()
        {
            this.id = 0;
            this.is_bot =false ;
            this.first_name = String.Empty;
            this.username = String.Empty;
            this.can_join_groups =false ;
            this.can_read_all_group_messages =false ;
            this.supports_inline_queries =false ;
        }
        public long id { get; set; }
        public bool is_bot { get; set; }
        public string first_name { get; set; }
        public string username { get; set; }
        public bool can_join_groups { get; set; }
        public bool can_read_all_group_messages { get; set; }
        public bool supports_inline_queries { get; set; }
    }
}
