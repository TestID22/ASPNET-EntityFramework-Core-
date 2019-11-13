using Microsoft.AspNetCore.Mvc;
using RazorTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorTest.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            Product product = new Product
            {
                ProductId = 1,
                Name = "Ноутбук",
                Description = "Hp with Kali Linux",
                Price = 50_000.54m,
                Category = "Computers"
            };
            ViewBag.StockLevel = 2;
            return View(product);
        }
       
    }
}
