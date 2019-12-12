using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class FakeProductStorage : IProductSaver
    {
        public IEnumerable<Product> Products => new List<Product>
        {
            new Product{Name = "SkateBoard", Price = 100},
            new Product{Name = "Snow", Price = 300}
        };
    }
}
