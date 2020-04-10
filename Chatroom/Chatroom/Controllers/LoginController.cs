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
    public class LoginController : Controller
    {
        private Login login;
        private readonly IConfiguration configuration;
        // GET

        public LoginController(IConfiguration config)
        {
            this.configuration = config;
        }
        
        //public IActionResult Index()
        //{
        //    string connectionstring = configuration.GetConnectionString("DefaultConnection");
        //    string text;
        //    SqlConnection connection = new SqlConnection(connectionstring);
        //    connection.Open();
        //    if (connection.State == ConnectionState.Open)
        //    {
        //        text = "Connectie open";
        //    }
        //    else
        //    {
        //        text = "Connectie niet open";
        //    }
        //    ViewData["TotalData"] = text;

        //    connection.Close();

        //    return View();
        //}

        public IActionResult Index()
        {
            return View();
        }

        public bool CheckUsername(string givenUsername)
        {
            bool temp;
            if (login.CheckUsername(givenUsername))
            {
                ViewData["TotalData"] = "Username klopt.";
                temp = true;
            }
            else
            {
                temp = false;
            }

            return temp;
        }

        public bool CheckPassword(string givenPassword)
        {
            bool temp;
            if (login.CheckPassword(givenPassword))
            {
                //ViewData[""]
                temp = true;
                login.CreateSession();
            }
            else
            {
                temp = false;
            }

            return temp;
        }
    }
}