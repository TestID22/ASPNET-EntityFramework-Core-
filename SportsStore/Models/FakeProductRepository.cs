using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class FakeProductRepository : IProductRepository
    {
        IEnumerable<Product> IProductRepository.Get => new List<Product> {
            new Product {Name = "Football", Price = 300m} ,
            new Product{Name = "Ball", Price = 33m },
            new Product{Name = "Skateboard", Price=100}
        };
        
    }
}
