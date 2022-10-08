using LanguageFeaturesCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeaturesCore.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index ()
        {
            List<string> results = new List<string>();
            foreach(Product p in Product.GetProducts())
            {
                string name = p?.Name ?? "<NoName>";
                decimal? price = p?.Price ?? 0;
                string relatedName = p?.Related?.Name ?? "Нет имени";
                results.Add(string.Format("Name : {0} , Price :{1}, relatedName :{2}", name, price, relatedName));
            }
            return View(results);
        }
    }
}
