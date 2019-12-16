using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class FakeProductStorage : IProductSaver
    {
        public IEnumerable<Product> Products
        {
            get
            {
                return new List<Product>
                {
                    new Product{ Name = "SkateBord", Price = 100 },
                    new Product{ Name = "SnowBoard", Price = 300 }
                    
                };
            }
        }

        //public IEnumerable<Product> Get => new List<Product> { new Product { Name = "Some" } };
        
    }
}
