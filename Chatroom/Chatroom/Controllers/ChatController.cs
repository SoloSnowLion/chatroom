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

namespace Chatroom.Controllers
{
    public class ChatController : Controller
    {
        // GET
        public IActionResult Index()
        {
            ChatroomContainer container = new ChatroomContainer(1);
            return View(container.ListAllChatrooms());
        }
    }
}