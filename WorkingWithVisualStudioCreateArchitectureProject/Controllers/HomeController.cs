using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq;
using WorkingWithVisualStudioCreateArchitectureProject.Models;

namespace WorkingWithVisualStudioCreateArchitectureProject.Controllers
{
    public class HomeController : Controller
    {
        //Используем null - условную операцию для устранения ошибки с неправильном объектом в словаре.
        public IActionResult Index()
            => View(SimpleRepository.ShraredRepository.Products.Where(p => p?.Price > 10000));
        
    }
}
