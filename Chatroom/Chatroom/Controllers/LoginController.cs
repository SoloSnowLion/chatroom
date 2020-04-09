using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Chatroom.Models;

namespace Chatroom.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        // GET

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }
        
        public IActionResult Index()
        {
            return View();
        }
    }
}