using System.Collections.Generic;
using System.Text;

namespace ApiFacade.TelegramLib.Models
{

    //{
    //"ok": true,
    //"result": {
    //"id": 1001321317,
    //"is_bot": true,
    //"first_name": "Friendly Bot",
    //"username": "iFriendlyBot",
    //"can_join_groups": true,
    //"can_read_all_group_messages": false,
    //"supports_inline_queries": false
    //}
    //}

    public class GetMeModel
    {
        public GetMeModel()
        {
            this.ok = false;
            this.result = new ResultModel();
        }
        public bool ok { get; set; }
        public ResultModel result { get; set; }
    }
}
