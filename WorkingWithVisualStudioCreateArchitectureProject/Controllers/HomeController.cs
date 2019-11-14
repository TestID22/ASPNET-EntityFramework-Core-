using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkingWithVisualStudioCreateArchitectureProject.Models;

namespace WorkingWithVisualStudioCreateArchitectureProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() 
            => View(SimpleRepository.ShraredRepository.Products);
        
    }
}
