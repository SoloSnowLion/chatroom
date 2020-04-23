using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
        BaseMssqlContext fiddle = new BaseMssqlContext();
        // GET
        public IActionResult Index()
        {
            // ChatroomContainer container = new ChatroomContainer(1);
            // container.ListAllChatrooms();
            BaseMssqlContext baseMssql = new BaseMssqlContext();
            return View();
        }
    }
}