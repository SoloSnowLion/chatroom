using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Chatroom.Models;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using Chatroom.Dataset;
using Chatroom.Models;

namespace Chatroom.Controllers
{
    public class ChatController : Controller
    {
        ChatroomContainer containerMain = new ChatroomContainer(1);

        // GET
        public IActionResult Index()
        {
            return View(containerMain.ListAllChatrooms());
        }

        [HttpPost]
        public bool CheckAccessToChatroom(int givenRoomId, int givenUserId)
        {
            bool returnVal = false;
            string SQL =
                "SELECT user_id FROM [Chatroom_User] WHERE user_id = @User_Id AND chatroom_id = @Chatroom_Id AND access_verified = 1";
            List<KeyValuePair<object, object>> param = new List<KeyValuePair<object, object>>();
            param.Add(new KeyValuePair<object, object>("Chatroom_Id", givenRoomId));
            param.Add(new KeyValuePair<object, object>("User_Id", givenUserId));
            DataTable dt = new BaseMssqlContext().ExecuteQuery(SQL, param);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (Convert.ToInt32(dt.Rows[0][0]) == givenUserId)
                {
                    returnVal = true;
                }
            }
            return returnVal;
        }
    }
}