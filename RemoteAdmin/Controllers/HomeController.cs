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
        public ViewResult Index() => View();


      

    }
}
