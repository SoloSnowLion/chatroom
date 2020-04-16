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

namespace Chatroom.Controllers
{
    public class ChatController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}