using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationTestCore.Models;

namespace WebApplicationTestCore.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Доброе Утро": "Скоро Спать" ;
            return View("Alex");
        }


        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        ///Http Post запрос будет получать данные введённые в форме(представлении, вьюхе) 
        [HttpPost]
        public ViewResult RsvpForm(GuessResponse guessResponse)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(guessResponse);
                return View("Thanks", guessResponse);
            }
            else
            {
                return View();
            }
        }

        public ViewResult ListResponses()
        {
            return View(Repository.GetResponses.Where(x => x.WillAttend == true));
        }
    }
}
