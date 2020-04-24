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
            ChatroomContainer temp = containerMain;
            bool returnVal = new bool();
            foreach (Models.Chatroom variable in containerMain.Chatrooms)
            {
                if (variable.GetId() == givenRoomId)
                {
                    returnVal = variable.CheckAccess(givenUserId);
                }
                else
                {
                    returnVal = false;
                }
            }

            return returnVal;
        }
    }
}