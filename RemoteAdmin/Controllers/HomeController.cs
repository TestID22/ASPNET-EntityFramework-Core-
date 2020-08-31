using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RemoteAdmin.Models;

namespace RemoteAdmin.Controllers
{
    public class HomeController : Controller
    {
        UserButton user;

        [HttpGet]
        public ViewResult Index()
        {
            return View(new string[] {"c#", "java", "null"});
        }

        [HttpPost]
        public ViewResult Index(UserButton user)
        {
            user.isPressed = true;
            return View("Index");
        }

        [HttpPost]
        public ViewResult Privacy()
        {
            Process.Start("cmd");
            return View("Privacy");
        }
       
    }
}
