using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductSaver repo;

        public ProductController(IProductSaver repo)
        {
            this.repo = repo;
        }
        public ViewResult List() => View(repo.Products);
    }
}
