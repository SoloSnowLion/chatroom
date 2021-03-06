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
using Microsoft.AspNetCore.Server.IIS.Core;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Chatroom.Controllers
{
    public class ChatController : Controller
    {
        ChatroomContainer containerMain; //= new ChatroomContainer(1);

        public ChatController()
        {
            this.containerMain = new ChatroomContainer(1);
            this.containerMain.FetchRooms();
        }

        // GET
        public IActionResult Index()
        {
            return View(containerMain.ListAllChatrooms());
        }
    }
}