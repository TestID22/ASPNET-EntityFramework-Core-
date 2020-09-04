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
            return View("Index");
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

        [HttpGet]
        public ViewResult Passwords()
        {
            return View("Passwords");
        }

        [HttpPost]
        public ViewResult Passwords(StolenPassword pass)
        {
            FakeDataBase.AddPassword(pass);
            FakeDataBase.GetDump(pass);
            return View("ShowPassword", FakeDataBase.GetPasswords);
        }

    }
}
